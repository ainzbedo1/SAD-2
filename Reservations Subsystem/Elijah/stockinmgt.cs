using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    public partial class stockinmgt : Form
    {
        public Inventorymgt reference { get; set; }
        MySqlConnection conn;
        dbconnector connect = new dbconnector();
        public MySqlConnection dbconnection;

        public stockinmgt()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=sad2_db; uid = root; pwd = root; Allow Zero Datetime=True ");
            InitializeComponent();
        }

        private void stockinmgt_Load(object sender, EventArgs e)
        {
            loadInventory();
            loadPurchasingData();
        }

        public void loadPurchasingData()
        {

            String query_purchase_order = "SELECT purchase_order.id as id, DATE_FORMAT(order_date, '%Y/%m/%d %H:%i %p') as date, " +
                " concat(staff.firstname,' ',staff.lastname) as staff, " +
                "total, purchase_order.status FROM purchase_order, staff " +
                "WHERE  purchase_order.status = 1 " +
                "AND purchase_order.staff_id = staff.id ORDER BY order_date ";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_purchase_order, conn);
            MySqlDataAdapter adp_purchase_order = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_purchase_order = new DataTable();
            adp_purchase_order.Fill(dt_purchase_order);

            dtgvPO.DataSource = dt_purchase_order;

            dtgvPO.Columns["id"].Visible = false;
            dtgvPO.Columns["date"].HeaderText = "Date";
            dtgvPO.Columns["staff"].HeaderText = "Staff";
            dtgvPO.Columns["total"].HeaderText = "Total";
            dtgvPO.Columns["status"].HeaderText = "Status";
        }

        public void loadInventory()
        {

            String query_inv = "SELECT name, quantity, expiration_date,minventory.status FROM minventory, menuitem WHERE minventory.product_id = menuitem.id";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_inv, conn);
            MySqlDataAdapter adp_inv = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_inv = new DataTable();
            adp_inv.Fill(dt_inv);

            dtgvInv.DataSource = dt_inv;

            dtgvInv.Columns["name"].HeaderText = "Date";
            dtgvInv.Columns["quantity"].HeaderText = "Quantity";
            dtgvInv.Columns["expiration_date"].HeaderText = "Expiration";
            dtgvInv.Columns["status"].HeaderText = "Status";
        }

        int po_id;
        private void dtgvPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgvPO.Rows[e.RowIndex].Cells["id"].Value.ToString());
                po_id = selected_id;
                loadPOLines();
            }
        }
        public void loadPOLines()
        {
            String query_order_line = "SELECT purchase_order_line.POL_id as id, menuitem.name as product," +
           " purchase_order_line.price, quantity as quantity, subtotal, (CASE WHEN purchase_order_line.status = 0 THEN 'Pending' WHEN purchase_order_line.status = 1 THEN 'Delivered' END) as status,supplierName as Supplier FROM supplier,purchase_order_line, " +
           " menuitem WHERE  menuitem.id = product_id AND purchase_order_id = '" + po_id + "'  AND " +
           " stocked_in = 0 AND menuitem.id = purchase_order_line.product_id AND purchase_order_line.supplier_id = supplier.id AND purchase_order_line.status != 2 group by id";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_order_line, conn);
            MySqlDataAdapter adp_order_line = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_order_line = new DataTable();
            adp_order_line.Fill(dt_order_line);

            dtgvPOL.DataSource = dt_order_line;

            dtgvPOL.Columns["id"].Visible = false;
            dtgvPOL.Columns["product"].HeaderText = "Product Name";
            dtgvPOL.Columns["quantity"].HeaderText = "Quantity";
            dtgvPOL.Columns["price"].HeaderText = "Price";
            dtgvPOL.Columns["subtotal"].HeaderText = "Subtotal";
            dtgvPOL.Columns["status"].HeaderText = "Status";
            dtgvPOL.Columns["Supplier"].HeaderText = "Supplier";

        }
        
        int pol;
        string prod;
        int quan;
        private void dtgvPOL_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                pol = int.Parse(dtgvPOL.Rows[e.RowIndex].Cells["id"].Value.ToString());
                prod = dtgvPOL.Rows[e.RowIndex].Cells["product"].Value.ToString();
                quan = int.Parse(dtgvPOL.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
                loadPOLines();
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked == true)
            {
                cb.Checked = true;
                expirationDtp.Visible = true;
                expirationDtp.Enabled = true;
            }
            else
            {
                cb.Checked = false;
                expirationDtp.Visible = false;
                expirationDtp.Enabled = false;
            }

        }

        private void StockInBtn_Click(object sender, EventArgs e)
        {
            string expiration;

            if (dtgvPO.Rows.Count < 1)
            {
                MessageBox.Show("Nothing to stock in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (expirationDtp.Visible == true)
                {
                    expiration = expirationDtp.Text;
                }
                else
                {
                   
                    expiration = "0000-00-00";
                }

                MessageBox.Show(expiration);

                string query_inventory_duplicate = "SELECT expiration_date FROM minventory WHERE expiration_date = '" + expiration + "' AND product_id = (SELECT id FROM menuitem where name = '" + prod + "')";
                conn.Open();
                MySqlCommand comm_inventory_duplicate = new MySqlCommand(query_inventory_duplicate, conn);
                MySqlDataAdapter adp_inventory_duplicate = new MySqlDataAdapter(comm_inventory_duplicate);
                conn.Close();
                DataTable dt_inventory_duplicate = new DataTable();
                adp_inventory_duplicate.Fill(dt_inventory_duplicate);


                if (dt_inventory_duplicate.Rows.Count > 0)
                {
                    // Increment Quantity of existing instance
                    string query_add_quantity = "UPDATE minventory set status = 1, quantity = quantity + " + quan + " where product_id = (SELECT id FROM menuitem where name = '" + prod + "') AND  expiration_date = '" + expiration + "'";
                    conn.Open();
                    MySqlCommand comm_add_quantity = new MySqlCommand(query_add_quantity, conn);
                    comm_add_quantity.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    // Add a new instance 
                    string query_inventory = "INSERT INTO minventory (product_id,quantity,expiration_date,status) VALUES((SELECT id FROM menuitem where name = '" + prod + "'),'" + quan + "','" + expiration + "', 1)";
                    conn.Open();
                    MySqlCommand comm_inventory = new MySqlCommand(query_inventory, conn);
                    comm_inventory.ExecuteNonQuery();
                    conn.Close();

                }

                string query_stockin_stat = "UPDATE purchase_order_line SET stocked_in = 1 WHERE purchase_order_id = " + po_id + " AND POL_id = " + pol + " ";

                conn.Open();
                MySqlCommand comm_stockin_stat = new MySqlCommand(query_stockin_stat, conn);
                comm_stockin_stat.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Products successfully stocked in!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadInventory();
                loadPurchasingData();
                dtgvPOL.DataSource = null;
            }
        }

    }
}

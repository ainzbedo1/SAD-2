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

namespace Hotel_Inventory
{
    public partial class stockinmgt : Form
    {
        public Inventorymgt reference { get; set; }
        public MySqlConnection dbconnection;

        public stockinmgt()
        {
            InitializeComponent();
        }

        private void stockinmgt_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
      /*      int purchase_order_id;
            int purchase_orderline_id;
            int quantity;
            string expiration;
            string prod_name;
            */
            if (dataGridView_deliveredorders.Rows.Count < 1)
            {
/*                MessageBox.Show("Nothing to stock in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                for (int i = 0; i < dtgvInv.Rows.Count; i++)
                {
                    purchase_order_id = int.Parse(dtgvInv.Rows[i].Cells["po_id"].Value.ToString());
                    purchase_orderline_id = int.Parse(dtgvInv.Rows[i].Cells["pol_id"].Value.ToString());
                    expiration = dtgvInv.Rows[i].Cells["expiration date"].Value.ToString();
                    prod_name = dtgvInv.Rows[i].Cells["name"].Value.ToString();
                    quantity = int.Parse(dtgvInv.Rows[i].Cells["quantity"].Value.ToString());

                    string query_inventory_duplicate = "SELECT expiration_date FROM product_inventory WHERE expiration_date = '" + expiration + "' AND products_id = (SELECT id FROM products where name = '" + prod_name + "')";
                    conn.Open();
                    MySqlCommand comm_inventory_duplicate = new MySqlCommand(query_inventory_duplicate, conn);
                    MySqlDataAdapter adp_inventory_duplicate = new MySqlDataAdapter(comm_inventory_duplicate);
                    conn.Close();
                    DataTable dt_inventory_duplicate = new DataTable();
                    adp_inventory_duplicate.Fill(dt_inventory_duplicate);

                    if (dt_inventory_duplicate.Rows.Count > 0)
                    {
                        // Increment Quantity of existing instance
                        string query_add_quantity = "UPDATE product_inventory set status = 'available', quantity = quantity + " + quantity + " where products_id = (SELECT id FROM products where name = '" + prod_name + "') AND  expiration_date = '" + expiration + "'";
                        conn.Open();
                        MySqlCommand comm_add_quantity = new MySqlCommand(query_add_quantity, conn);
                        comm_add_quantity.ExecuteNonQuery();
                        conn.Close();

                    }
                    else
                    {
                        // Add a new instance 
                        string query_inventory = "INSERT INTO product_inventory (products_id,quantity,expiration_date,status) VALUES((SELECT id FROM products where name = '" + prod_name + "'),'" + quantity + "','" + expiration + "', 'available')";
                        conn.Open();
                        MySqlCommand comm_inventory = new MySqlCommand(query_inventory, conn);
                        comm_inventory.ExecuteNonQuery();
                        conn.Close();

                    }

                    // Tag as stocked in
                    string query_stockin_stat = "UPDATE purchase_order_line SET stocked_in = 'yes' WHERE purchase_order_id = " + purchase_order_id + " AND id = " + purchase_orderline_id + " ";

                    conn.Open();
                    MySqlCommand comm_stockin_stat = new MySqlCommand(query_stockin_stat, conn);
                    comm_stockin_stat.ExecuteNonQuery();
                    conn.Close();

                    // Insert Stock In Log
                    string query_log = "INSERT INTO inventory_log (process_type,date,product,quantity,remarks,staff_id) VALUES('Stock In (Purchased)' , current_timestamp(),'" + prod_name + "','" + quantity + "', 'Purchased Item from " + CaPY_SAD.Login.UserDisplayDetails.name + "', " + CaPY_SAD.Login.UserDisplayDetails.id + ")";
                    conn.Open();
                    MySqlCommand comm_log = new MySqlCommand(query_log, conn);
                    comm_log.ExecuteNonQuery();
                    conn.Close();

                }

                MessageBox.Show("Products successfully stocked in!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toInventory.Clear();
*/
            }




        }
    }
}

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
    public partial class orderlistmgt : Form
    {
        public Form previousform { get; set; }
        MySqlConnection conn;

        dbconnector connect = new dbconnector();

        DataTable orders = new DataTable();
        
        //public mainform reference { get; set; }
        public MySqlConnection dbconnection;
        public string itemid;

        public orderlistmgt()
        {
            conn = new MySqlConnection("SERVER=localhost; DATABASE=sad2_db; uid = root; pwd = root; Allow Zero Datetime=True ");
            InitializeComponent();
        }

        private void orderlistmgt_Load(object sender, EventArgs e)
        {
            supplierCmbData();
            LoadVendors();
            loadPurchasingData();
            orders.Columns.Add("Name", typeof(string));
            orders.Columns.Add("Price", typeof(string));
            orders.Columns.Add("Quantity", typeof(string));
            orders.Columns.Add("Subtotal", typeof(string));
            orders.Columns.Add("Supplier_id", typeof(int));
            delBtn.Visible = false;
            delBtn.Enabled = false;
        }

        public void loadPurchasingData()
        {

            String query_purchase_order = "SELECT purchase_order.id as id, DATE_FORMAT(order_date, '%Y/%m/%d %H:%i %p') as date, " +
                " concat(staff.firstname,' ',staff.lastname) as staff, " +
                "total, purchase_order.status FROM purchase_order, staff " +
                "WHERE  purchase_order.status = 0 " +
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



            String query_purchase_order_com = "SELECT purchase_order.id as id, DATE_FORMAT(order_date, '%Y/%m/%d %H:%i %p') as date, " +
          " concat(staff.firstname,' ',staff.lastname) as staff, " +
          "total, purchase_order.status FROM purchase_order, staff " +
          "WHERE  purchase_order.status = 1 " +
          "AND purchase_order.staff_id = staff.id ORDER BY order_date ";

            conn.Open();
            MySqlCommand comm2 = new MySqlCommand(query_purchase_order_com, conn);
            MySqlDataAdapter adp_purchase_orderc = new MySqlDataAdapter(comm2);
            conn.Close();
            DataTable dt_purchase_orderc = new DataTable();
            adp_purchase_orderc.Fill(dt_purchase_orderc);

            dtgvPOC.DataSource = dt_purchase_orderc;

            dtgvPOC.Columns["id"].Visible = false;
            dtgvPOC.Columns["date"].HeaderText = "Date";
            dtgvPOC.Columns["staff"].HeaderText = "Staff";
            dtgvPOC.Columns["total"].HeaderText = "Total";
            dtgvPOC.Columns["status"].HeaderText = "Status";


            String query_purchase_order_can= "SELECT purchase_order.id as id, DATE_FORMAT(order_date, '%Y/%m/%d %H:%i %p') as date, " +
        " concat(staff.firstname,' ',staff.lastname) as staff, " +
        "total, purchase_order.status FROM purchase_order, staff " +
        "WHERE  purchase_order.status = 2 " +
        "AND purchase_order.staff_id = staff.id ORDER BY order_date ";

            conn.Open();
            MySqlCommand comm3 = new MySqlCommand(query_purchase_order_can, conn);
            MySqlDataAdapter adp_purchase_ordercl = new MySqlDataAdapter(comm3);
            conn.Close();
            DataTable dt_purchase_ordercl = new DataTable();
            adp_purchase_ordercl.Fill(dt_purchase_ordercl);

            dtgvPOCL.DataSource = dt_purchase_ordercl;

            dtgvPOCL.Columns["id"].Visible = false;
            dtgvPOCL.Columns["date"].HeaderText = "Date";
            dtgvPOCL.Columns["staff"].HeaderText = "Staff";
            dtgvPOCL.Columns["total"].HeaderText = "Total";
            dtgvPOCL.Columns["status"].HeaderText = "Status";


        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (vendorName.Text != "")
            {
                if (dtgvOrd.SelectedRows.Count > 0)
                {

                    string query_order = "INSERT INTO purchase_order " +
                        "(staff_id,total,order_date,status) VALUES" +
                        "(" +"'" + 1 + "'," +
                        "'" + decimal.Parse(txtTotal.Text) + "'," +
                        " current_timestamp(),'0')";

                    conn.Open();
                    MySqlCommand comm_order = new MySqlCommand(query_order, conn);
                    comm_order.ExecuteNonQuery();
                    conn.Close();

                    for (int i = 0; i <= dtgvOrd.Rows.Count - 1; i++)
                    {
                        
                        string pname = dtgvOrd.Rows[i].Cells["Name"].Value.ToString();

                        string query_prods = "SELECT id FROM menuitem WHERE name = '" + pname + "'";
                        conn.Open();
                        MySqlCommand comm_prods = new MySqlCommand(query_prods, conn);
                        MySqlDataAdapter adp_prods = new MySqlDataAdapter(comm_prods);
                        conn.Close();
                        DataTable dt_prods = new DataTable();
                        adp_prods.Fill(dt_prods);

                        string prod_id = dt_prods.Rows[0][0].ToString();
                        string prod_price = dtgvOrd.Rows[i].Cells["Price"].Value.ToString();
                        string prod_quantity = dtgvOrd.Rows[i].Cells["Quantity"].Value.ToString();
                        string prod_subtotal = dtgvOrd.Rows[i].Cells["Subtotal"].Value.ToString();
                        string supp = dtgvOrd.Rows[i].Cells["Supplier_id"].Value.ToString();

                        string query_order_line = "INSERT INTO purchase_order_line (product_id,purchase_order_id,quantity,price,subtotal,supplier_id,stocked_in,status)" +
                            " VALUES('" + int.Parse(prod_id) + "',(SELECT max(id) FROM purchase_order),'" + int.Parse(prod_quantity) + "','" + decimal.Parse(prod_price) + "','" + decimal.Parse(prod_subtotal) + "','"+supp+"','0','0')";

                        conn.Open();
                        MySqlCommand comm_order_line = new MySqlCommand(query_order_line, conn);
                        comm_order_line.ExecuteNonQuery();
                        conn.Close();
                        loadPurchasingData();
                    }

                    MessageBox.Show("Record saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    orders.Clear();
                   
               
                }

                else
                {
                    MessageBox.Show("Please add data to the table before saving!", "No data to be saved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Supplier details missing!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            /*
            if (itemTxt.Text == "" && txtVendor.Text == "" && txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill up all the textfields.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

    */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void supplierCmbData()
        {

            String query_suppliers = "SELECT * FROM supplier";

            MySqlCommand comm_suppliers = new MySqlCommand(query_suppliers, conn);
            comm_suppliers.CommandText = query_suppliers;
            conn.Open();
            MySqlDataReader drd_suppliers = comm_suppliers.ExecuteReader();

            //supplierCmb.Items.Clear();
            //while (drd_suppliers.Read())
            //{
            //    supplierCmb.Items.Add(drd_suppliers["supplierName"].ToString());
            //}
            conn.Close();

        }
        public void itemcmbData()
        {

            String query_suppliers = "SELECT * FROM product";

            MySqlCommand comm = new MySqlCommand(query_suppliers, conn);
            comm.CommandText = query_suppliers;
            conn.Open();
            MySqlDataReader drd = comm.ExecuteReader();

            //supplierCmb.Items.Clear();
            while (drd.Read())
            {
                //itemcmb.Items.Add(drd["supplierName"].ToString());
            }
            conn.Close();

        }

        public void LoadVendors()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();

            var dbconnect = new dbconnector();
            using (MySqlConnection conn = connect.connector())
            {
                conn.Open();
                String getCustomer = "SELECT SUPPLIERNAME FROM SUPPLIER ";
                MySqlCommand comm = new MySqlCommand(getCustomer, conn);
                comm.CommandText = getCustomer;
                MySqlDataReader drd = comm.ExecuteReader();

                if (drd.HasRows == true)
                {
                    while (drd.Read())
                        namesCollection.Add(drd["SUPPLIERNAME"].ToString());
                }

                drd.Close();
                conn.Close();
                vendorName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                vendorName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                vendorName.AutoCompleteCustomSource = namesCollection;
            }
        }

        public void LoadProducts()
        {
            AutoCompleteStringCollection productCollection = new AutoCompleteStringCollection();
            if (vendorName.Text == "")
            {
                //MessageBox.Show("Please input the name of the vendor", "Empty Textfield", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                //SELECT THE PRODUCT THAT IS AVAILABLE TO A SPECIFIC SUPPLIER
                String getCustomer = "SELECT NAME FROM MENUITEM "
                                    + "INNER JOIN PRODUCT_HAS_SUPPLIER ON MENUITEM.ID = PRODUCT_ID "
                                    + "INNER JOIN SUPPLIER ON SUPPLIER_ID = SUPPLIER.ID "
                                    + "WHERE SUPPLIERNAME LIKE'%" + vendorName.Text + "%'";

                MySqlCommand comm = new MySqlCommand(getCustomer, conn);
                comm.CommandText = getCustomer;
                MySqlDataReader drd = comm.ExecuteReader();

                if (drd.HasRows == true)
                {
                    while (drd.Read())
                        productCollection.Add(drd["NAME"].ToString());
                }

                drd.Close();
                conn.Close();
                productTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                productTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                productTxt.AutoCompleteCustomSource = productCollection;
            }

        }

        private void vendorName_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
            clear();


        }

        private void productTxt_TextChanged(object sender, EventArgs e)
        {
            String price = "SELECT cost_price FROM menuitem WHERE name = '" + productTxt.Text + "' ";

            MySqlCommand comm = new MySqlCommand(price, conn);
            comm.CommandText = price;
            conn.Open();
            MySqlDataReader drd_suppliers = comm.ExecuteReader();
            
            while (drd_suppliers.Read())
            {
                txtprice.Text = drd_suppliers["cost_price"].ToString();
            }
            conn.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             subtotal();
        }
        public void subtotal()
        {
            string price = txtprice.Text;
            decimal parsed_price = decimal.Parse(price);

            string quantity = quanNum.Value.ToString();
            int parsed_quantity = int.Parse(quantity);


            decimal subtotal = parsed_price * parsed_quantity;
            string string_subtotal = subtotal.ToString();

            txtSub.Text = string_subtotal;
        }

        public void clear()
        {
            txtprice.Text= "0";
            txtSub.Text = "0";
            productTxt.Clear();
            quanNum.Value = 1;
            getTotal();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query_supplier = "SELECT id FROM supplier WHERE supplierName ='" + vendorName.Text + "'";
            conn.Open();
            MySqlCommand comm_supplier = new MySqlCommand(query_supplier, conn);
            MySqlDataAdapter adp_supplier = new MySqlDataAdapter(comm_supplier);
            conn.Close();
            DataTable dt_supplier = new DataTable();
            adp_supplier.Fill(dt_supplier);

            string supplier_id = dt_supplier.Rows[0][0].ToString();


            Boolean Prod_duplicate = false;
            int prod_id = 0;

            for (int i = 0; i < dtgvOrd.Rows.Count; i++)
            {

                if (productTxt.Text == dtgvOrd.Rows[i].Cells["Name"].Value.ToString())
                {
                    Prod_duplicate = true;
                    prod_id = i;
                }
            }


            if (productTxt.Text == "" || txtprice.Text == "" || quanNum.Text == "")
            {
                MessageBox.Show("Please fill up all fields!", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (quanNum.Value == 0)
            {
                MessageBox.Show("Please input quantity!", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Prod_duplicate == true)
            {

                string quantity = dtgvOrd.Rows[prod_id].Cells["Quantity"].Value.ToString();
                string price = dtgvOrd.Rows[prod_id].Cells["Price"].Value.ToString();
                dtgvOrd.Rows[prod_id].Cells["Quantity"].Value = Int32.Parse(quanNum.Text) + int.Parse(quantity);

                decimal number = Decimal.Parse(price) * Int32.Parse(dtgvOrd.Rows[prod_id].Cells["Quantity"].Value.ToString());
                dtgvOrd.Rows[prod_id].Cells[3].Value = number.ToString();
                

            }
            else
            {
                orders.Rows.Add(productTxt.Text, txtprice.Text, quanNum.Text, txtSub.Text, supplier_id);
                dtgvOrd.DataSource = orders;
                subtotal();
                
            }
            getTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgvOrd.CurrentCell.RowIndex;
            dtgvOrd.Rows.RemoveAt(rowIndex);
            getTotal();
        }


        public void getTotal()
        {
            decimal total = 0;

            for (int i = 0; i <= dtgvOrd.Rows.Count - 1; i++)
            {

                string subs = dtgvOrd.Rows[i].Cells["Subtotal"].Value.ToString();

                decimal decimal_sub = decimal.Parse(subs);

                total = total + decimal_sub;


            }
            string total_string = total.ToString();
            txtTotal.Text = total_string;
        }
        int po_id;
        private void dtgvPO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cancelBtn.Visible = true;
                cancelBtn.Enabled = true;

                int selected_id = int.Parse(dtgvPO.Rows[e.RowIndex].Cells["id"].Value.ToString());
                po_id = selected_id;
                loadPOLines();
            }
        }
        public void loadPOLines()
        {
            String query_order_line = "SELECT purchase_order_line.POL_id as id, menuitem.name as product," +
           " purchase_order_line.price, quantity as quantity, subtotal, (CASE WHEN purchase_order_line.status = 0 THEN 'Pending' WHEN purchase_order_line.status = 1 THEN 'Delivered' END) as status,supplierName as Supplier FROM supplier,purchase_order_line, " +
           " menuitem WHERE  menuitem.id = product_id AND purchase_order_id = '"+po_id+"'  AND " +
           " menuitem.id = purchase_order_line.product_id AND purchase_order_line.supplier_id = supplier.id AND purchase_order_line.status != 2 group by id";

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
        public static int orderline_id;
        private void dtgvPOL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delBtn.Visible = true;
            delBtn.Enabled = true;


            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgvPOL.Rows[e.RowIndex].Cells["id"].Value.ToString());
                orderline_id = selected_id;

            }
            
        }
     
        private void delBtn_Click(object sender, EventArgs e)
        {

            string query_del_update = "UPDATE purchase_order_line SET status = 1  WHERE POL_id = " + orderline_id + " ";
            conn.Open();
            MySqlCommand comm_del_update = new MySqlCommand(query_del_update, conn);
            comm_del_update.ExecuteNonQuery();
            conn.Close();

            string query_change_delivered = "UPDATE purchase_order, purchase_order_line SET purchase_order.status = 1 WHERE purchase_order.id = purchase_order_line.purchase_order_id AND purchase_order_line.status = 1";
            conn.Open();
            MySqlCommand comm_change_delivered = new MySqlCommand(query_change_delivered, conn);
            comm_change_delivered.ExecuteNonQuery();
            conn.Close();

            string query_change_ordered = "UPDATE purchase_order, purchase_order_line SET purchase_order.status = 0 WHERE purchase_order.id = purchase_order_line.purchase_order_id AND purchase_order_line.status = 0";
            conn.Open();
            MySqlCommand comm_change_ordered = new MySqlCommand(query_change_ordered, conn);
            comm_change_ordered.ExecuteNonQuery();
            conn.Close();
            loadPurchasingData();
            dtgvPOL.DataSource = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string query_del_update = "UPDATE purchase_order SET status = 2 WHERE id = " + po_id + " ";

            conn.Open();

            MySqlCommand comm_del_update = new MySqlCommand(query_del_update, conn);
            comm_del_update.ExecuteNonQuery();
            
            conn.Close();
            

            loadPurchasingData();
            dtgvPOL.DataSource = null;
            cancelBtn.Enabled = false;
            cancelBtn.Enabled = false;
            loadPurchasingData();

        }
        int poc_id;
        private void dtgvPOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgvPOC.Rows[e.RowIndex].Cells["id"].Value.ToString());
                poc_id = selected_id;
                loadPOLinesC();
            }
        }

        public void loadPOLinesC()
        {
            String query_order_line = "SELECT purchase_order_line.POL_id as id, menuitem.name as product," +
           " purchase_order_line.price, quantity as quantity, subtotal, (CASE WHEN purchase_order_line.status = 0 THEN 'Pending' WHEN purchase_order_line.status = 1 THEN 'Delivered' END) as status,supplierName as Supplier FROM supplier,purchase_order_line, " +
           " menuitem WHERE  menuitem.id = product_id AND purchase_order_id = '" + poc_id + "'  AND " +
           " menuitem.id = purchase_order_line.product_id AND purchase_order_line.supplier_id = supplier.id AND purchase_order_line.status != 2 group by id";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_order_line, conn);
            MySqlDataAdapter adp_order_line = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_order_line = new DataTable();
            adp_order_line.Fill(dt_order_line);

            dtgvPOLC.DataSource = dt_order_line;

            dtgvPOLC.Columns["id"].Visible = false;
            dtgvPOLC.Columns["product"].HeaderText = "Product Name";
            dtgvPOLC.Columns["quantity"].HeaderText = "Quantity";
            dtgvPOLC.Columns["price"].HeaderText = "Price";
            dtgvPOLC.Columns["subtotal"].HeaderText = "Subtotal";
            dtgvPOLC.Columns["status"].HeaderText = "Status";
            dtgvPOLC.Columns["Supplier"].HeaderText = "Supplier";

        }
        int pocl_id;
        private void dtgvPOCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selected_id = int.Parse(dtgvPOCL.Rows[e.RowIndex].Cells["id"].Value.ToString());
                pocl_id = selected_id;
                loadPOLinesCL();
            }
        }

        public void loadPOLinesCL()
        {
            String query_order_line = "SELECT purchase_order_line.POL_id as id, menuitem.name as product," +
           " purchase_order_line.price, quantity as quantity, subtotal, (CASE WHEN purchase_order_line.status = 0 THEN 'Pending' WHEN purchase_order_line.status = 1 THEN 'Delivered' END) as status,supplierName as Supplier FROM supplier,purchase_order_line, " +
           " menuitem WHERE  menuitem.id = product_id AND purchase_order_id = '" + pocl_id + "'  AND " +
           " menuitem.id = purchase_order_line.product_id AND purchase_order_line.supplier_id = supplier.id AND purchase_order_line.status != 2 group by id";

            conn.Open();
            MySqlCommand comm = new MySqlCommand(query_order_line, conn);
            MySqlDataAdapter adp_order_line = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt_order_line = new DataTable();
            adp_order_line.Fill(dt_order_line);

            dtgvPOLCL.DataSource = dt_order_line;

            dtgvPOLCL.Columns["id"].Visible = false;
            dtgvPOLCL.Columns["product"].HeaderText = "Product Name";
            dtgvPOLCL.Columns["quantity"].HeaderText = "Quantity";
            dtgvPOLCL.Columns["price"].HeaderText = "Price";
            dtgvPOLCL.Columns["subtotal"].HeaderText = "Subtotal";
            dtgvPOLCL.Columns["status"].HeaderText = "Status";
            dtgvPOLCL.Columns["Supplier"].HeaderText = "Supplier";

        }
    }
}

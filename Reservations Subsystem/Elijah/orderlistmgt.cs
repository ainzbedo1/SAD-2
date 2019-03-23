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
    public partial class orderlistmgt : Form
    {
        public Form previousform { get; set; }
        MySqlConnection conn;

     
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
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        { /*
            if (itemTxt.Text == "" && txtVendor.Text == "" && txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill up all the textfields.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                
            }
            
    */
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

            supplierCmb.Items.Clear();
            while (drd_suppliers.Read())
            {
                supplierCmb.Items.Add(drd_suppliers["supplierName"].ToString());
            }
            conn.Close();

        }
        public void itemcmbData()
        {

            String query_suppliers = "SELECT * FROM product";

            MySqlCommand comm = new MySqlCommand(query_suppliers, conn);
            comm.CommandText = query_suppliers;
            conn.Open();
            MySqlDataReader drd = comm.ExecuteReader();

            supplierCmb.Items.Clear();
            while (drd.Read())
            {
                itemcmb.Items.Add(drd["supplierName"].ToString());
            }
            conn.Close();

        }
    }
}

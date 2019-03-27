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
    public partial class itemmgt : Form
    {
        public Inventorymgt reference { get; set; }
        public MySqlConnection dbconnection;

        dbconnector connect = new dbconnector();
        MySqlDataAdapter adapter;
        DataTable dt;


        public itemmgt()
        {
            InitializeComponent();
            btn_update.Enabled = false;
            btn_create.Enabled = true;
        }

        private void itemmgt_Load(object sender, EventArgs e)
        {
            loadmenu();
            supp();
        }

        public void supp()
        {
            using (MySqlConnection conn = connect.connector())
            {
                String query = "SELECT supplierName FROM supplier";


                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.CommandText = query;
                conn.Open();
                MySqlDataReader drd = comm.ExecuteReader();

                cmbSup.Items.Clear();
                while (drd.Read())
                {
                    cmbSup.Items.Add(drd["supplierName"].ToString());
                }
                conn.Close();
            }
        }

            public void loadmenu()
        {

            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM sad2_db.menuitem WHERE status = 1";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dtgv_itemmgt.DataSource = dt;

                dtgv_itemmgt.Columns["id"].Visible = false;
                dtgv_itemmgt.Columns["status"].Visible = false;
                dtgv_itemmgt.Columns["name"].HeaderText = "Name";
                dtgv_itemmgt.Columns["sell_price"].HeaderText = "Sell Price";
                dtgv_itemmgt.Columns["cost_price"].HeaderText = "Cost Price";

            }
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }
        int product_id;
        private void dtgv_itemmgt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                btn_update.Enabled = true;
                btn_create.Enabled = false;
                product_id = int.Parse(dtgv_itemmgt.Rows[e.RowIndex].Cells["id"].Value.ToString());
                using (MySqlConnection conn = connect.connector())
                {

                    String query = "SELECT id,sell_price,cost_price,name FROM menuitem where id = '" + product_id + "' AND status = 1";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.CommandText = query;
                    conn.Open();
                    MySqlDataReader drd = comm.ExecuteReader();

                    while (drd.Read())
                    {
                        txtitemcode.Text = drd["id"].ToString();
                        txtsell.Text = drd["sell_price"].ToString();
                        txtcost.Text = drd["cost_price"].ToString();
                        txtitemname.Text = drd["name"].ToString();
                    }
                }
            }
        }
        public void clear()
        {
            txtitemcode.Clear();
            txtcost.Clear();
            txtitemname.Clear();
            txtsell.Clear();
        }

        private void itemmgt_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_create.Enabled = true;
            clear();


        }

        public static int sup_id;
        public void get_supid()
        {

            using (MySqlConnection conn = connect.connector())
            {

                String query = "SELECT id FROM supplier where supplierName = '" + cmbSup.Text + "'";

                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.CommandText = query;
                conn.Open();
                MySqlDataReader drd = comm.ExecuteReader();

                while (drd.Read())
                {
                    sup_id = int.Parse(drd["id"].ToString());
                }
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            get_supid();

            using (MySqlConnection conn = connect.connector())
            {
                if (txtitemname.Text == "" || txtsell.Text == "" || txtcost.Text == "" || cmbType.Text == "")
                {
                    MessageBox.Show("Please fill up all fields!", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int typevalue;
                    string type = cmbType.Text;
                    if (type == "Hotel")
                    {
                        typevalue = 0;
                    }
                    else
                    {
                        typevalue = 1;
                    }
                    string query = "INSERT INTO menuitem(name,sell_price,cost_price, status, type)" +
                            "VALUES('" + txtitemname.Text + "','" + txtsell.Text + "','" + txtcost.Text + "',1,'" + typevalue + "')";
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();

                    string q = "INSERT INTO product_has_supplier(product_id,supplier_id)" +
                            "VALUES((SELECT MAX(id) from menuitem)," + sup_id + ")";
                    conn.Open();
                    MySqlCommand comms = new MySqlCommand(q, conn);
                    comms.ExecuteNonQuery();
                    conn.Close();
                }
                loadmenu();
                clear();
            }


            clear();
        }

        public viewarchive frmview;
        private void button1_Click(object sender, EventArgs e)
        {
            frmview = new viewarchive();
            frmview.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            get_supid();
            using (MySqlConnection conn = connect.connector())
            {

                if (txtitemname.Text == "" || txtsell.Text == "" || txtcost.Text == "")
                {
                    MessageBox.Show("Please fill up all fields!", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string query = "UPDATE menuitem SET name = '" + txtitemname.Text + "',sell_price = '" + txtsell.Text + "',cost_price =  '" + txtcost.Text + "' WHERE id = " + product_id + "";
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    string query2 = "UPDATE product_has_supplier SET product_id = '" + product_id + "' WHERE supplier_id = " + sup_id + "";
                    conn.Open();
                    MySqlCommand comm2 = new MySqlCommand(query2, conn);
                    comm2.ExecuteNonQuery();
                    conn.Close();


                }
            }
            loadmenu();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = connect.connector())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to archive this record?", "Archive?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "UPDATE menuitem SET status = 0 WHERE id = " + product_id + "";
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                }
            }
            loadmenu();
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemmgt_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
    
}

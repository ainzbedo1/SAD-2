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
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM sad2_db.menu_item";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dtgv_itemmgt.DataSource = dt;

                dtgv_itemmgt.Columns["id"].Visible = false;
                dtgv_itemmgt.Columns["name"].HeaderText = "Name";
                //dtgv_itemmgt.Columns["description"].HeaderText = "Description";
                dtgv_itemmgt.Columns["price"].HeaderText = "Price";

            }
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Hide();
        }

        private void dtgv_itemmgt_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                btn_update.Enabled = true;
                btn_create.Enabled = false;
                int product_id = int.Parse(dtgv_itemmgt.Rows[e.RowIndex].Cells["id"].Value.ToString());
                using (MySqlConnection conn = connect.connector())
                {

                    String query = "SELECT * FROM menu_item where id = '" + product_id + "'";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.CommandText = query;
                    conn.Open();
                    MySqlDataReader drd = comm.ExecuteReader();

                    while (drd.Read())
                    {
                        txtitemcode.Text = drd["id"].ToString();
                        txtdesc.Text = drd["description"].ToString();
                        txtitemname.Text = drd["name"].ToString();
                        txtprice.Text = drd["price"].ToString();

                    }
                }


            }
        }
        public void clear()
        {
            txtitemcode.Clear();
            txtdesc.Clear();
            txtitemname.Clear();
            txtprice.Clear();
        }

        private void itemmgt_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_create.Enabled = true;
            clear();


        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            clear();
        }

        public viewarchive frmview;
        private void button1_Click(object sender, EventArgs e)
        {
            frmview = new viewarchive();
            //frmim.reference = this;
            frmview.Show();
        }
    }
    
}

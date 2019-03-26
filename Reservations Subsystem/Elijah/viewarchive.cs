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
    public partial class viewarchive : Form
    {
        public Inventorymgt reference { get; set; }
        public MySqlConnection dbconnection;

        dbconnector connect = new dbconnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        public viewarchive()
        {

            InitializeComponent();
            dbconnection = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        }

        private void viewproducts_Load(object sender, EventArgs e)
        {

            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT * FROM menuitem WHERE status = 0";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                dtgvarc.DataSource = dt;

                dtgvarc.Columns["id"].Visible = false;
                dtgvarc.Columns["status"].Visible = false;
                dtgvarc.Columns["name"].HeaderText = "Name";
                dtgvarc.Columns["sell_price"].HeaderText = "Sell Price";
                dtgvarc.Columns["cost_price"].HeaderText = "Cost Price";

            }
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {

        }

        private void btn_activate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewarchive_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
    }
}

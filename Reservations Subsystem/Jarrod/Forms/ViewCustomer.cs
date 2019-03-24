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
    public partial class ViewCustomer : Form
    {
        public MySqlConnection conn;
        public ReservationCalendarForm referencefrm1 { get; set; }
        public ViewCustomer()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=prototype_sad;Uid=root;Pwd=root;");
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

        }

        public void refreshcCustomer()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select id, name AS Name, company AS Company, address AS Address, phone AS Contact, email AS E-Mail, passport AS Passport, nationality AS Nationality, gender AS Gender, birthdate AS Birthdate, birthplace AS Birthplace, comment AS Comment from customer", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                view.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    view.Columns["id"].Visible = false;
                }

                conn.Close();
                foreach (DataGridViewColumn ya in view.Columns)
                {
                    ya.SortMode = DataGridViewColumnSortMode.NotSortable;
                    ya.Width = 100;
                }
                foreach (DataGridViewRow ro in view.Rows)
                {
                    ro.Height = 60;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            referencefrm1.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}

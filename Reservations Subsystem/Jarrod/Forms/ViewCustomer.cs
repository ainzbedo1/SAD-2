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
        public int currID;
        public bool alter = true;
        public ViewCustomer()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;SslMode=none;");
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            refreshcCustomer();
        }

        public void refreshcCustomer()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select id, name AS Name, company AS Company, address AS Address, phone AS Contact, email AS eMail, passport AS Passport, nationality AS Nationality, gender AS Gender, birthdate AS Birthdate, birthplace AS Birthplace, comment AS Comment from customer", conn);
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
                    ya.Width = 150;
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

        public void searchCustomer()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select id, name AS Name, company AS Company, address AS Address, phone AS Contact, email AS eMail, passport AS Passport, nationality AS Nationality, gender AS Gender, birthdate AS Birthdate, birthplace AS Birthplace, comment AS Comment from customer WHERE name LIKE '%"+ txtSearch.Text + "%' gender LIKE '%" + txtSearch.Text + "%' nationality LIKE '%" + txtSearch.Text + "%'", conn);
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
                    ya.Width = 150;
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

        public void filterCustomer()
        {
            string strquery = "";
            
            if (alter)
            {
                alter = false;
                strquery = "Select id, name AS Name, company AS Company, address AS Address, phone AS Contact, email AS eMail, passport AS Passport, nationality AS Nationality, gender AS Gender, birthdate AS Birthdate, birthplace AS Birthplace, comment AS Comment from customer ORDER BY Name ASC";
            }
            else
            {
                alter = true;
                strquery = "Select id, name AS Name, company AS Company, address AS Address, phone AS Contact, email AS eMail, passport AS Passport, nationality AS Nationality, gender AS Gender, birthdate AS Birthdate, birthplace AS Birthplace, comment AS Comment from customer ORDER BY Name DESC";
            }
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(strquery, conn);
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
                    ya.Width = 150;
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
            AddCustomerForm cusadd = new AddCustomerForm();
            cusadd.reference= this;
            this.Hide();
            if (cusadd.ShowDialog() == DialogResult.OK)
            {
                refreshcCustomer();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            currID = int.Parse(view.SelectedRows[0].Cells[0].Value.ToString());
            EditCustomerForm cusedit = new EditCustomerForm();
            cusedit.reference = this;
            cusedit.currID = this.currID;
            this.Hide();
            if (cusedit.ShowDialog() == DialogResult.OK)
            {
                refreshcCustomer();
            }
        }

        #region drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        //search
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchCustomer();
        }
    }
}

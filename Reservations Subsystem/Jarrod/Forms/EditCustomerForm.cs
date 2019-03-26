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
    public partial class EditCustomerForm : Form
    {
        public MySqlConnection conn;
        public Form reference { get; set; }
        public int currID { get; set; }
        public EditCustomerForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;SslMode=none;");
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            initializeData();
        }

        public void initializeData()
        {
            try
            {   
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select * from customer WHERE id =" + currID, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    SurName.Text = dt.Rows[0]["name"].ToString();
                    company.Text = dt.Rows[0]["company"].ToString();
                    address.Text = dt.Rows[0]["address"].ToString();
                    phone.Text = dt.Rows[0]["phone"].ToString();
                    email.Text = dt.Rows[0]["email"].ToString();
                    passport.Text = dt.Rows[0]["passport"].ToString();
                    nationality.Text = dt.Rows[0]["nationality"].ToString();
                    gender.Text = dt.Rows[0]["gender"].ToString();
                    
                    bdate.Value = Convert.ToDateTime(dt.Rows[0]["birthdate"].ToString());
                    
                    bplace.Text = dt.Rows[0]["birthplace"].ToString();
                    comment.Text = dt.Rows[0]["comment"].ToString();

                }

                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah!" + ee);
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE customer SET name ='" + SurName.Text + "', company ='" + company.Text + "', address ='" + address.Text + "', phone ='" + phone.Text + "', email ='" + email.Text + "', passport ='" + passport.Text + "', nationality ='" + nationality.Text + "', gender ='" + gender.Text + "', birthdate ='" + bdate.Value.ToString("yyyy-MM-dd") + "', birthplace ='" + bplace.Text + "', comment ='" + comment.Text + "' WHERE id = '" + currID + "';", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}

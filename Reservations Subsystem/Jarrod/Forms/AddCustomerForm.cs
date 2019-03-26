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
    public partial class AddCustomerForm : Form
    {
        public MySqlConnection conn;
        public Form reference { get; set; }

        public AddCustomerForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;SslMode=none;");
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("INSERT into customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace, comment) values('" + SurName.Text + "','" + company.Text + "','" + address.Text + "','" + phone.Text + "','" + email.Text + "','" + passport.Text + "','" + nationality.Text + "','" + gender.Text + "','" + bdate.Value.ToString("yyyy-MM-dd") + "','" + bplace.Text + "','" + comment.Text + "')", conn);
                //int id = (int)command.ExecuteScalar();
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Data Inserted");
                else MessageBox.Show("Data not inserted");
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

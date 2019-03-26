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
    public partial class UMS_Accounts : Form
    {
        public main_form reference { get; set; }
        public UMS_Accounts()
        {
            InitializeComponent();
        }

        private void UMS_Accounts_Load(object sender, EventArgs e)
        {
            refreshAccounts();
        }
        private void refreshAccounts()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM user";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            accountsGridView.DataSource = dt;
        }

        private void UMS_Accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
    }
}

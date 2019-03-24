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
    public partial class UMS_Login : Form
    {
        DBConnect db;
        MySqlConnection con;
        public UMS_Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            db = new DBConnect();
            con = db.connect();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT firstname, inventoryAccess, reservationAccess, posAccess, menuAccess, userAccess FROM user INNER JOIN roles", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}

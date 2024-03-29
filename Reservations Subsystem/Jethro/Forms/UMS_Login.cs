﻿using System;
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
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT firstname, inventoryAccess, reservationAccess, posAccess, menuAccess, userAccess " +
                                                        "FROM user " +
                                                        "INNER JOIN roles " +
                                                        "ON user.roles_id = roles.id " +
                                                        "WHERE username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                String firstname = dt.Rows[0][0].ToString();
                bool inventory = dt.Rows[0][1].Equals(true);
                bool reservation = dt.Rows[0][2].Equals(true);
                bool pos = dt.Rows[0][3].Equals(true);
                bool posmenu = dt.Rows[0][4].Equals(true);
                bool accounts = dt.Rows[0][5].Equals(true);
                main_form mainform = new main_form(inventory, reservation, pos, posmenu, accounts);
                mainform.reference = this;
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password do not match.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UMS_Login_Load(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

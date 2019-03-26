using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations_Subsystem
{
    public partial class main_form : Form
    {
        bool posmenuStatus;
        public UMS_Login reference { get; set; }
        public main_form()
        {
            InitializeComponent();
        }
        public main_form(bool reservation, bool inventory, bool pos, bool posmenu, bool accounts)
        {
            InitializeComponent();

            if (!reservation) btn_Sched.Enabled = false;
            if (!inventory) btn_Inv.Enabled = false;
            if (!pos) btn_POS.Enabled = false;
            if (!accounts) btn_Acc.Enabled = false;
            posmenuStatus = posmenu;
        }
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                dynamic result = MessageBox.Show("Do you want to Exit?", "Radio Management", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btn_Sched_Click(object sender, EventArgs e)
        {
            ReservationCalendarForm resCalendar = new ReservationCalendarForm();
            resCalendar.reftomain = this;
            resCalendar.Show();
            this.Hide();
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            ROS_Main ros = new ROS_Main(posmenuStatus);
            ros.reference = this;
            ros.Show();
            this.Hide();
        }

        private void btn_Inv_Click(object sender, EventArgs e)
        {
            Inventorymgt inv = new Inventorymgt();
            inv.reference = this;
            inv.Show();
            this.Hide();
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            UMS_Accounts acc = new UMS_Accounts();
            acc.reference = this;
            acc.Show();
            this.Hide();
        }
    }
}

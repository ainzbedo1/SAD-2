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
    public partial class ROS_Main : Form
    {
        public ROS_Main()
        {
            InitializeComponent();
        }

        //
        private void viewDSRButton_Click(object sender, EventArgs e)
        {
            ROS_DSR ros = new ROS_DSR();
            ros.reference = this;
            this.Hide();
            ros.Show();
        }
        private void viewMenuButton_Click(object sender, EventArgs e)
        {
            ROS_Menu menu = new ROS_Menu();
            menu.reference = this;
            this.Hide();
            menu.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //this.Close()
        }
        private void ROS_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Redirect to Main Menu
        }
    }
}

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
    public partial class ROS_Menu : Form
    {
        public ROS_Main reference { get; set; }
        public ROS_Menu()
        {
            InitializeComponent();
        }
        private void ROS_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

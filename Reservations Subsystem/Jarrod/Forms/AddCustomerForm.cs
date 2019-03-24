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
        public AddReservationView reference { get; set; }

        public AddCustomerForm()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;SslMode=none;");
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}

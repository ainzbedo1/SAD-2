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
    public partial class ViewCustomer : Form
    {
        public ReservationCalendarForm referencefrm1 { get; set; }
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //referencefrm1.Show();
            this.Close();
        }

        private void ViewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            referencefrm1.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}

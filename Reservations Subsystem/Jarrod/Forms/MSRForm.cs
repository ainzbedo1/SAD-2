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
    
    public partial class MSRForm : Form
    {

        public MSR referencefrm1 { get; set; }

        public MSRForm()
        {
            InitializeComponent();
        }

        private void crvDataTable_Load(object sender, EventArgs e)
        {
        }

        private void MSRForm_Load(object sender, EventArgs e)
        {
           
        }

        public void dgvLoad(DataTable dt)
        {
            reportMonthly crpt = new reportMonthly();
            crpt.Database.Tables["monthlyReport"].SetDataSource(dt);

            crvDataTable.ReportSource = null;
            crvDataTable.ReportSource = crpt;

        }
    }
}

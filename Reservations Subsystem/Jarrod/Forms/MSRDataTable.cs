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
    public partial class MSR : Form
    {
        public ReservationCalendarForm referencefrm1 { get; set; }
        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private DataTable monthlyReportDatable { get; set; }

        public MSR()
        {
            InitializeComponent();
        }
        
        public DateTime StartDate 
        {
            set { startDate = value; }
            get { return startDate; }
        }
        public DateTime EndDate
        {
            set { endDate = value; }
            get { return endDate; }
        }
        public DataTable MonthlyReportData
        {
            set { monthlyReportDatable = value; }
            get { return monthlyReportDatable; }
        }

        
        private void MSR_Load(object sender, EventArgs e)
        {
        }

        public void LoadMrsDgv(DateTime startDateDgv, DateTime endDateDgv)
        {
            ReservationDataService myResDataServ = new ReservationDataService();

            DataTable storeData = myResDataServ.MsrDataSource(startDateDgv, endDateDgv);
            dgvMsr.DataSource = storeData;
            MonthlyReportData = storeData;
            StartDate = startDateDgv;
            EndDate = endDate;

        }

        private void btnGenerateMsr_Click(object sender, EventArgs e)
        {
            
            try
            {
                MSRForm frm = new MSRForm();
                ReservationDataService resData = new ReservationDataService();
                frm.referencefrm1 = this;
                frm.dgvLoad(MonthlyReportData);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

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
    public partial class FrmOccupancy : Form
    {
        public ReservationCalendarForm referencefrm1 { get; set; }
        public FrmOccupancy()
        {
            InitializeComponent();
        }

        private void FrmOccupancy_Load(object sender, EventArgs e)
        {

        }
        public void LoadOccupancyRep(DateTime startDateDgv, DateTime endDateDgv)
        {
            try
            {
                ReportOcc crpt = new ReportOcc();
                ReservationDataService myResDataServ = new ReservationDataService();

                DataTable storeData = myResDataServ.Occupancy(startDateDgv, endDateDgv);

                //dgvMsr.DataSource = storeData;
                //MonthlyReportData = storeData;
                //StartDate = startDateDgv;
                //EndDate = endDate;
                crpt.Database.Tables["OccReport"].SetDataSource(storeData);

                crvOccReport.ReportSource = null;
                crvOccReport.ReportSource = crpt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}

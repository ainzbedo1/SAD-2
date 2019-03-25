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
    public partial class FrmStateAccount : Form
    {
        public AddReservationView referencefrm1 { get; set; }
        public int resId { get; set; }
        public FrmStateAccount()
        {
            InitializeComponent();
        }
        public int ResId {
            set {resId = value;}
            get { return resId; }


        }

        private void FrmStateAccount_Load(object sender, EventArgs e)
        {
        }
        public void LoadReport(int custId, DateTime startDate, DateTime endDate)
        {
            try
            {
                rptStateAccount crpt = new rptStateAccount();
                ReservationDataService myResDataServ = new ReservationDataService();

                DataTable storeData = myResDataServ.FindGroupRes(custId, startDate, endDate);

                //dgvMsr.DataSource = storeData;
                //MonthlyReportData = storeData;
                //StartDate = startDateDgv;
                //EndDate = endDate;
                crpt.Database.Tables["StateAcc"].SetDataSource(storeData);

                crvStateAcc.ReportSource = null;
                crvStateAcc.ReportSource = crpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

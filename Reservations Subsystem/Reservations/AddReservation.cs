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
    public partial class AddReservation : Form
    {
        private DateTime dateStart;
        public ReservationCalendarForm referencefrm1 { get; set; }
        //public DateTime startDate { get; set; }
        private DateTime startDate;
        private DateTime endDate;
        private int numberOfDays { get; set; }
        private string roomType { get; set; } 
        private string roomNumber { get; set; }
       
        public AddReservation()
        {
            InitializeComponent();

        }
        public string RoomType
        {
            set { roomType = value; }
            get { return roomType;  }
        }
        public string RoomNumber
        {
            set { roomNumber = value; }
            get { return roomNumber;  }
        }

        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }
        public DateTime EndDate
        {
            set { endDate = value; }
            get { return startDate; }

        }
        public int NumberOfDays
        {
            set { numberOfDays = value; }
            get { return numberOfDays;  }
        }
        private void AddReservation_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dtpStartDate.CustomFormat = "dd MMMM yyyy dddd";
            dtpEndDate.CustomFormat = "dd MMMM yyyy dddd";
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            //MessageBox.Show(NumberOfDays.ToString());
            NumberOfDays = (endDate - startDate).Days;
            nudDays.Value = numberOfDays;
            cmbRoomType.Text = RoomType;
            cmbRoomNumber.Text = RoomNumber;
            cmbPerNight.SelectedIndex = 0;
            lblReserveDays.Text = nudDays.Value.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblPerNight.Text = nudDays.ToString();
          /*
            if (nudDays.Value < numberOfDays && nudDays.Value == 1)
            {
                dtpStartDate.Value = startDate.AddDays(-1);
                dtpEndDate.Value = endDate.AddDays(-1);
            }
            else if(nudDays.Value > numberOfDays)
            {

            }
            else
            {
            }
            oldValue = numericUpDown.Value;
            //dtpEndDate.Value = endDate.AddDays(Convert.ToDouble(nudDays.Value));
            */
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpEndDate.Value = (startDate - endDate).Days;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPerNight.Text = cmbPerNight.Text;
            int amtOfNights = Convert.ToInt32(cmbPerNight.Text);
            int amtReserveDays = Convert.ToInt32(nudDays.Text);
            
            lblTotalAccomadation.Text = (amtOfNights * amtReserveDays).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation();

        }
    }
}

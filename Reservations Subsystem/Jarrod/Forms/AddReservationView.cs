﻿using System;
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
    public partial class AddReservationView : Form
    {
        public ReservationCalendarForm referencefrm1 { get; set; }
        public event EventHandler OnShowReservationInfo;
        public CustomerInfo theCustomerInfo { get; set; }
        public ReservationInfo theReservation { get; set; }
        public MyButton referenceButton { get; set; }
        private bool editForm { get; set; }
        private string name { get; set; }
        public int viewMonth { get; set; }
        public int viewYear { get; set; }
        public bool changeDetected = false;


        public string RoomId
        {
            set { txtRoomId.Text = value; }
            get { return txtRoomId.Text; }
        }
        /*
        public int CustomerId
        {
            set { customerId = value; }
            get { return customerId; }
        }
        */

        public Boolean EditForm
        {
            get { return editForm; }
            set { editForm = value; }
        }


        public string RoomType
        {
            get { return cmbRoomType.Text; }
            set { cmbRoomType.Text = value; cmbRoomType.SelectedIndex = cmbRoomType.FindStringExact(value); }
        }
        public string RoomNumber
        {
            get { return cmbRoomNumber.Text; }
            set { cmbRoomNumber.Text = value; }
        }
        public DateTime StartDate
        {
            get { return dtpStartDate.Value; }
            set { dtpStartDate.Value = value; }

        }
        public DateTime EndDate
        {
            get { return dtpEndDate.Value; }
            set { dtpEndDate.Value = value; }

        }
        public string NameAddView
        {
            get { return txtCustomerName.Text; }
            set { txtCustomerName.Text = value; }
        }
        public string Description
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }

        public decimal LengthOfStay
        {
            get { return lengthOfStay.Value; }
            set { lengthOfStay.Value = value; }
        }



        public string TotalAccomadation
        {
            get { return lblTotalAccomadation.Text; }
            set { lblTotalAccomadation.Text = (Convert.ToInt32(lengthOfStay.Value) * Convert.ToInt32(cmbPerNight.Text)).ToString(); }
        }
        public string LblPerNight
        {
            get { return lblPerNight.Text; }
            set { lblPerNight.Text = value; }
        }
        public string LblReserveDays
        {
            get { return lblReserveDays.Text; }
            set { lblReserveDays.Text = value; }
        }

        public void testwhat(object sender, EventArgs e)
        {
            if (OnShowReservationInfo != null)
            {
                OnShowReservationInfo(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("an error has occured");
            }

        }
        public void setValuesBasedOnReservationId(string roomType, string roomNumber, DateTime startDate, DateTime endDate, string description)
        {
            RoomType = roomType;
            RoomNumber = roomNumber;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;

        }
        public AddReservationView()
        {

            InitializeComponent();
            // CustomerInfo _customerInfo = new CustomerInfo();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dtpStartDate.CustomFormat = "dd MMMM yyyy dddd";
            dtpEndDate.CustomFormat = "dd MMMM yyyy dddd";

        }
        public AddReservationView(ReservationInfo resInfo, RoomInfo roomInfo)
        {
            InitializeComponent();
            // CustomerInfo _customerInfo = new CustomerInfo();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dtpStartDate.CustomFormat = "dd MMMM yyyy dddd";
            dtpEndDate.CustomFormat = "dd MMMM yyyy dddd";

        }

        private void EditFormEnabled()
        {
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;

        }
        private void LoadRoomComboBoxes()
        {
            List<RoomTextBoxItems> room = new List<RoomTextBoxItems>();
            RoomDataService 

        }
        private void AddReservation_Load(object sender, EventArgs e)
        {
            MessageBox.Show(editForm.ToString());
            //if the form is in edit mode
            if (editForm)
            {
                EditFormEnabled();
                MessageBox.Show(theCustomerInfo.Name.ToString());
                MessageBox.Show("The changed detected was" + changeDetected.ToString());
                cmbRoomType.Text = RoomType;
                cmbRoomNumber.Text = RoomNumber.ToString();
                cmbPerNight.SelectedIndex = 0;

                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblReserveDays = LengthOfStay.ToString();
                LblPerNight = cmbPerNight.Text;
                TotalAccomadation = (Convert.ToInt32(LblReserveDays) * Convert.ToInt32(LblPerNight)).ToString();
                txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);

                txtCustomerName.Text = theCustomerInfo.Name.ToString();
                txtCustomerName.ReadOnly = true;


            }
            else
            {


                cmbRoomType.Text = RoomType;
                cmbRoomNumber.Text = RoomNumber.ToString();
                cmbPerNight.SelectedIndex = 0;

                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblReserveDays = LengthOfStay.ToString();
                LblPerNight = cmbPerNight.Text;
                TotalAccomadation = (Convert.ToInt32(LblReserveDays) * Convert.ToInt32(LblPerNight)).ToString();
            }


            //lengthOfStay.Value = LengthOfStay; 
            // cmbRoomType.Text = RoomType;
            //OnShowReservationInfo(this, EventArgs.Empty);

            /*
            dtpStartDate.Value = startDate;
            dtpEndDate.Value = endDate;
            //MessageBox.Show(NumberOfDays.ToString());
            NumberOfDays = (endDate - startDate).Days;
            nudDays.Value = numberOfDays;
            cmbRoomType.Text = RoomType;
            cmbRoomNumber.Text = RoomNumber.ToString();
            cmbPerNight.SelectedIndex = 0;
            lblReserveDays.Text = nudDays.Value.ToString();
            */
            //dtpStartDate.Value = StartDate;
            /// dtpEndDate.Value = EndDate;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblPerNight.Text = lengthOfStay.ToString();
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
            // int amtReserveDays = Convert.ToInt32(lengthOfStay.Text);

            lblTotalAccomadation.Text = TotalAccomadation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if the form is in an edit form state
            if (EditForm)
            {
                MessageBox.Show(changeDetected.ToString());
            }

            else
            {
                ReservationInfo reserveClass = new ReservationInfo();
                // Boolean occupied = true;

                // if reservation details are bad
                // check for date range
                // check for missing customer in

                //perform a search if duplicate customername is in database
                if (String.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("there are missing fields please fill it in");
                }
                else // if reservation details are good
                {
                    ReservationDataService frm = new ReservationDataService();
                    CustomerInfo myCustomer = new CustomerInfo();
                    ReservationInfo myReservation = new ReservationInfo();


                    myReservation.RoomId = RoomId;
                    myReservation.Desc = Description;
                    myReservation.startDate = StartDate;
                    myReservation.EndDate = EndDate;
                    //myReservation.LenghtOfStay = lengthOfStay;
                    myReservation.TotalPrice = Convert.ToInt32(TotalAccomadation);
                    myCustomer.Name = NameAddView;
                    frm.verifyCustomerInfoAndCreateReservation(myCustomer, myReservation, referencefrm1);
                    this.Close();
                    this.Dispose();

                    referencefrm1.Show();


                }

            }



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            /*
            AddCustomerForm frm = new AddCustomerForm();
            frm.reference = this;
            frm.ShowDialog();
            */
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            referencefrm1.Show();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            changeDetected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            ReservationDataService myDataService = new ReservationDataService();
            int resId = theReservation.ResId;
            myDataService.DeleteReservation(resId);
            MessageBox.Show("this is my reservation ID" + resId.ToString());
            //referencefrm1.displayCalendar(StartDate.Month , )
            MessageBox.Show("my month" + viewMonth.ToString());
            MessageBox.Show("my year" + viewYear.ToString());
            //referencefrm1.DeleteButtonById(btn)

            referencefrm1.displayCalendar(viewMonth, viewYear);
            referencefrm1.DeleteButtonById(resId);
            referencefrm1.displayReservationButt(viewMonth, viewYear);
            this.Close();
            referencefrm1.Show();



        }
            //reservation
            /*
                if (MessageBox.Show("A customer with same name exists already" +
                "would you like create a new customer with the same name" +
                "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                // if user clicked yes 


                }
                */

        
    }
}

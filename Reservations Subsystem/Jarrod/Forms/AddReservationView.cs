﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        decimal myValue = 0;
        public bool resButtClicked = false;
        private int dgvMonth { get; set; }
        private int dgvYear { get; set; }
        //private bool CustomerInfoExist = false;

        public int DgvMonth
        {
            set { dgvMonth = value; }
            get { return dgvMonth; }
        }
        public int DgvYear
        {
            set { dgvYear = value; }
            get { return dgvYear; }
        }
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

        public string RoomRate
        {
            get { return txtRate.Text; }
            set { txtRate.Text = value; }
        }

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
        public string CustomerName
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
            set { lblTotalAccomadation.Text = value; }
        }
        public string LblPricePerNight
        {
            get { return lblPerNight.Text; }
            set { lblPerNight.Text = value; }
        }
        public string LblNumOfNights
        {
            get { return lblNumOfNights.Text; }
            set { lblNumOfNights.Text = value; }
        }
        public CustomerInfo TheCustomerInfo
        {
            get { return theCustomerInfo; }
            set { theCustomerInfo = value; }
        }


        //public void AutoCompleteCustomer
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
        //this method only fires on update
        public void setValuesBasedOnReservationId(RoomInfo customInfo, string roomType, string roomNumber, DateTime startDate, DateTime endDate, string description, int roomRate)
        {
            lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
            dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
            dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
            txtRate.TextChanged -= txtRate_TextChanged;

            RoomId = customInfo.RoomId;
            RoomType = roomType;
            RoomNumber = roomNumber;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            RoomRate = roomRate.ToString();
            LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
            LblNumOfNights = LengthOfStay.ToString();
            LblPricePerNight = RoomRate.ToString();
            TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * (Convert.ToInt32(LblPricePerNight))).ToString();
           

            //TotalAccomadation = (Convert.ToInt32(LblReserveDays) * (Convert.ToInt32(LblPerNight))).ToString();

            lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            txtRate.TextChanged += txtRate_TextChanged;
        }
        public void SetValuesOnSelection(DateTime startDate, DateTime endDate)
        {
            lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
            dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
            dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
            txtRate.TextChanged -= txtRate_TextChanged;

            StartDate = startDate;
            EndDate = endDate;

            lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            txtRate.TextChanged += txtRate_TextChanged;
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

        public void EditFormIsTrue()
        {
            btnRemoveCust.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnEditCustomer.Enabled = true;
            btnAddCustomer.Enabled = false;
            txtCustomerName.ReadOnly = true;

        }
        public void AddFormIsTrue()
        {
            btnRemoveCust.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            btnEditCustomer.Enabled = true;
            btnAddCustomer.Enabled = false;
            txtCustomerName.ReadOnly = true;

        }
        public void LoadRoomComboBoxes()
        {
            //get combo box items
            // filter by type
            //wpfUC.UcWpf uc = elementHost1.Child as wpfUC.UcWpf;
            //ComboBox hello = elementHOs   
            List<RoomTextBoxItems> myRooms = new List<RoomTextBoxItems>();

            RoomDataService myRoomDataService = new RoomDataService();
            myRooms = myRoomDataService.getRoomInfoByType(cmbRoomType.Text);
            foreach(RoomTextBoxItems item in myRooms)
            { 
                cmbRoomNumber.Items.Add(item);
            }
            //RoomDataService 

        }
        private void LoadRoomTypeCombo()
        {
            //get combo box items
            // filter by type
            //wpfUC.UcWpf uc = elementHost1.Child as wpfUC.UcWpf;
            //ComboBox hello = elementHOs   
            List<string> myRooms = new List<string>();

            RoomDataService myRoomDataService = new RoomDataService();
            myRooms = myRoomDataService.getRoomTypes();
            foreach (var item in myRooms)
            {
                cmbRoomType.Items.Add(item);
            }
            //RoomDataService 

        }
        private void LoadCustomerNames()
        {
            CustomerDataService custDataService = new CustomerDataService();
            StringCollection nameCollection = new StringCollection();
            //nameCollection = custDataService.AutoCompleteCollection();
            txtCustomerName.AutoCompleteCustomSource = custDataService.AutoCompleteCollection(); 
        }
        private void AddReservation_Load(object sender, EventArgs e)
        {
                LoadCustomerNames();
            //btnAddCustomer.Visible = false;
            //if the form is in edit mode
            if (editForm)
            {

                // numeric up down Valuechanged event is removed before setting values
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
                txtRate.TextChanged -= txtRate_TextChanged;

                LoadRoomComboBoxes();
                EditFormIsTrue();

                /*
                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblReserveDays = LengthOfStay.ToString();
                LblPerNight= RoomRate.ToString();
                MessageBox.Show(LblPerNight.ToString());
                MessageBox.Show(LblReserveDays.ToString());
                */
                //MessageBox.Show((Convert.ToInt32(LblPerNight) * Convert.ToInt32(LblReserveDays)).ToString());


                //TotalAccomadation = (Convert.ToInt32(LblReserveDays) * (Convert.ToInt32(LblPerNight))).ToString();
                txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
                CustomerName = theCustomerInfo.Name;
                myValue = theReservation.LenghtOfStay;

                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
                txtRate.TextChanged += txtRate_TextChanged;
                MessageBox.Show(RoomId.ToString() + "my room id");

            }
            else if (resButtClicked)
            {
                MessageBox.Show("resbutt is true");
                //
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;

                var dateNow = DateTime.Now;
                var date = dateNow;
                StartDate = DateTime.Today;
                dtpEndDate.Value = DateTime.Today.AddDays(1);
             
                //LoadRoomComboBoxes();
                LoadRoomTypeCombo();
                cmbRoomType.Text = RoomType;
                cmbRoomNumber.Text = RoomNumber.ToString();
                cmbPerNight2.SelectedIndex = 0;

                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                LblPricePerNight = cmbPerNight2.Text;
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();
                RoomRate = txtRate.Text;


                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;

                // button disable
                btnEditCustomer.Enabled = false;
                btnDelete.Enabled = false;

            }
            else //if reservation creation is by selection 
            {
                MessageBox.Show("Selection ");
                dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;

                LoadRoomTypeCombo();
                cmbRoomType.Text = RoomType;
                cmbRoomNumber.Text = RoomNumber.ToString();
                cmbPerNight2.SelectedIndex = 0;

                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                RoomRate = txtRate.Text;
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();

                LblPricePerNight = cmbPerNight2.Text;

                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;


                //button
                btnEditCustomer.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;

                EndDate = StartDate.AddDays(1);
                LengthOfStay = Convert.ToDecimal((dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days);
                LblNumOfNights = LengthOfStay.ToString();
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();


                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;

            }
            else
            {

                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;

                LengthOfStay = Convert.ToDecimal((dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days);
                LblNumOfNights = LengthOfStay.ToString();
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();


                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            
            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;

                StartDate = EndDate.AddDays(-1);
                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();


                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;


            }
            else
            {

                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();


                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomRate = cmbPerNight2.Text;

            /*
            lblPerNight.Text = cmbPerNight2.Text;
            int amtOfNights = Convert.ToInt32(cmbPerNight2.Text);

            lblTotalAccomadation.Text = TotalAccomadation;
            */
        }
        public ReservationInfo SettingReservationInfo()
        {
            ReservationInfo myReservation = new ReservationInfo();
            //myReservation.ResId = theReservation.ResId;
            myReservation.RoomId = RoomId;
            myReservation.Desc = Description;
            myReservation.startDate = StartDate;
            myReservation.EndDate = EndDate;
            //myReservation.LenghtOfStay = lengthOfStay;
            myReservation.TotalPrice = Convert.ToInt32(TotalAccomadation);
            myReservation.LenghtOfStay = Convert.ToInt32(lengthOfStay.Value);
            myReservation.RoomRate = Convert.ToInt32(RoomRate);
            return myReservation;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            ReservationCalendarForm myResCalFor = new ReservationCalendarForm();
            int startDay = StartDate.Day;
            int startMonth = StartDate.Month;
            int startYear = StartDate.Year;

            int endDay = EndDate.Day;
            int endMonth = EndDate.Month;
            int endYear = EndDate.Year;


            bool emptyTextBox = false;
            foreach (Control child in grpBoxRoomData.Controls)
            {
                if (child is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(child.Text))
                    {
                        emptyTextBox = true;
                    }    
                }

           
            }

            if (EditForm) // if the form is in editing state perform an update
            {
                MessageBox.Show(RoomId.ToString()+"my room id");
                if (emptyTextBox)
                {
                    MessageBox.Show("room data is empty please fill in room data");

                }
                else if (myResCalFor.ReservationCheckAdvanced(startDay, startMonth, startYear, endDay, endMonth, endYear, Convert.ToInt32(RoomId)) > 1)
                {
                    MessageBox.Show("This is valid dates conflict with existing reservation");
                }
                else if( StartDate == null || EndDate == null)
                {
                    MessageBox.Show("No Dates have been assigned for this reservation");

                }
                else if (String.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    MessageBox.Show("A customer is missing in the reservation");
                }
                else
                {
                    // if txtCustomer is ReadOnly do not insert into Customer table just UPdate Reservation
                    if (txtCustomerName.ReadOnly)
                    {
                        MessageBox.Show("IM UPDATING BOIS");
                        ReservationDataService frm = new ReservationDataService();
                        ReservationInfo myReservation = new ReservationInfo();


                        //myCustomer.Name = CustomerName;
                        MessageBox.Show(myReservation.ResId.ToString()+"My res ID");
                        frm.UpdateReservation(myReservation.ResId, Convert.ToInt32(myReservation.RoomId), Convert.ToInt32(theCustomerInfo.Id), myReservation.Desc,
                            myReservation.StartDate, myReservation.EndDate, 0, myReservation.TotalPrice, myReservation.LenghtOfStay,
                            myReservation.RoomRate);
                        //frm.verifyCustomerInfoAndCreateReservation(myCustomer, myReservation, referencefrm1);

                        this.Close();
                        this.Dispose();


                        referencefrm1.DeleteAllButtons();
                        referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                        referencefrm1.Show();
                    }
                    //Insert into customer table and update Reservation
                    else
                    {
                        CustomerDataService customDataServ = new CustomerDataService();
                        DataTable duplicatesTable = customDataServ.CheckDuplicateNames(txtCustomerName.Text);
                        if (duplicatesTable.Rows.Count == 1)
                        {
                            MessageBox.Show("This name conflicts with another person name please try another");
                        }
                        else
                        {
                            MessageBox.Show("inserting and updating");

                            ReservationDataService frm = new ReservationDataService();
                            CustomerInfo myCustomer = new CustomerInfo();
                            ReservationInfo myReservation = new ReservationInfo();

                            /*
                            myReservation.RoomId = RoomId;
                            myReservation.Desc = Description;
                            myReservation.startDate = StartDate;
                            myReservation.EndDate = EndDate;
                            //myReservation.LenghtOfStay = lengthOfStay;
                            myReservation.TotalPrice = Convert.ToInt32(TotalAccomadation);
                            myReservation.LenghtOfStay = Convert.ToInt32(lengthOfStay.Value);
                            myReservation.RoomRate = Convert.ToInt32(RoomRate);
                            */
                            myReservation = SettingReservationInfo();
                            myCustomer.Name = CustomerName;
                            CustomerDataService custDataServ = new CustomerDataService();

                            long lastInsertedCustomer = custDataServ.InsertIntoCustomer(theCustomerInfo.Name, theCustomerInfo.Company, theCustomerInfo.Address,
                            theCustomerInfo.Phone, theCustomerInfo.Email, theCustomerInfo.Passport, theCustomerInfo.Nationality, theCustomerInfo.Gender,
                            theCustomerInfo.BirthDate, theCustomerInfo.BirthPlace, theCustomerInfo.Comment);

                            frm.UpdateReservation(myReservation.ResId, Convert.ToInt32(myReservation.RoomId), Convert.ToInt32(lastInsertedCustomer), myReservation.Desc,
                            myReservation.StartDate, myReservation.EndDate, 0, myReservation.TotalPrice, myReservation.LenghtOfStay,
                            myReservation.RoomRate);

                            this.Close();
                            this.Dispose();
                            referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                            referencefrm1.Show();
                        }
                    }

                }
            }
            else if(emptyTextBox){
                MessageBox.Show("room data is empty please fill in room data");

            }
            else if (myResCalFor.ReservationCheckAdvanced(startDay, startMonth, startYear, endDay, endMonth, endYear, Convert.ToInt32(RoomId))>= 1)
            {
                MessageBox.Show("This is valid dates conflict with existing reservation");
            }
            else // new reservation has been made by reservation button on by selection
            {
                ReservationInfo reserveClass = new ReservationInfo();
                CustomerDataService customDataServ = new CustomerDataService();
                // Boolean occupied = true;

                // if reservation details are bad
                // check for date range
                // check for missing customer in
                DataTable duplicatesTable = customDataServ.CheckDuplicateNames(txtCustomerName.Text);

                //perform a search if duplicate customername is in database
                if (String.IsNullOrWhiteSpace(txtCustomerName.Text) || StartDate == null || EndDate == null)
                {
                    MessageBox.Show("there are missing fields please fill it in");
                }
                else if (duplicatesTable.Rows.Count == 1)
                {
                    MessageBox.Show("This name conflicts with another person name please try another");
                }
                else // if reservation details are good
                {


                    //if a customer was selected from autocomplete
                    if (txtCustomerName.ReadOnly)
                    {
                        ReservationDataService frm = new ReservationDataService();
                        CustomerInfo myCustomer = new CustomerInfo();
                        ReservationInfo myReservation = new ReservationInfo();

                        /*
                        myReservation.RoomId = RoomId;
                        myReservation.Desc = Description;
                        myReservation.startDate = StartDate;
                        myReservation.EndDate = EndDate;
                        //myReservation.LenghtOfStay = lengthOfStay;
                        myReservation.TotalPrice = Convert.ToInt32(TotalAccomadation);
                        myReservation.LenghtOfStay = Convert.ToInt32(lengthOfStay.Value);
                        myReservation.RoomRate = Convert.ToInt32(RoomRate);
                        */
                        myCustomer.Name = CustomerName;
                        myReservation = SettingReservationInfo();

                        frm.AddReservation(Convert.ToInt32(myReservation.RoomId), Convert.ToInt32(theCustomerInfo.Id), myReservation.Desc,
                            myReservation.StartDate, myReservation.EndDate, 0, myReservation.TotalPrice, myReservation.LenghtOfStay,
                            myReservation.RoomRate);
                        //frm.verifyCustomerInfoAndCreateReservation(myCustomer, myReservation, referencefrm1);

                        this.Close();
                        this.Dispose();
                        referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                        referencefrm1.Show();
                    }
                    else //if a new customer added
                    {
                        ReservationDataService frm = new ReservationDataService();
                        CustomerInfo myCustomer = new CustomerInfo();
                        ReservationInfo myReservation = new ReservationInfo();
                        /*
                        myReservation.RoomId = RoomId;
                        myReservation.Desc = Description;
                        myReservation.startDate = StartDate;
                        myReservation.EndDate = EndDate;
                        //myReservation.LenghtOfStay = lengthOfStay;
                        myReservation.TotalPrice = Convert.ToInt32(TotalAccomadation);
                        myReservation.LenghtOfStay = Convert.ToInt32(lengthOfStay.Value);
                        myReservation.RoomRate = Convert.ToInt32(RoomRate);
                        */
                        myReservation = SettingReservationInfo();
                        myCustomer.Name = CustomerName;
                        frm.verifyCustomerInfoAndCreateReservation(myCustomer, myReservation, referencefrm1);

                        this.Close();
                        this.Dispose();
                        referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                        referencefrm1.Show();
                    }


                }

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm frm = new AddCustomerForm();
            frm.reference = this;
            frm.SurName = CustomerName;
            frm.ShowDialog();
            
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


            referencefrm1.displayCalendar(viewMonth, viewYear);
            referencefrm1.DeleteButtonById(resId);
            referencefrm1.displayReservationButt(viewMonth, viewYear);
            this.Close();
            referencefrm1.Show();



        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDataService myRoomDataService = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();
            myRoomInfo = myRoomDataService.getRoomInfoByRoomNumber(cmbRoomNumber.Text);
            RoomId = myRoomInfo.RoomId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cmbRoomNumber.Items.Clear();
            LoadRoomComboBoxes();
            
        }

        private void lengthOfStay_ValueChanged(object sender, EventArgs e)
        {
            if (editForm)
            {
                //decimal oldValue = theReservation.LenghtOfStay;
                if (lengthOfStay.Value > myValue)
                {
                    dtpEndDate.Value = EndDate.AddDays(1);
                }
                else
                {

                    dtpEndDate.Value = EndDate.AddDays(-1);
                    if (lengthOfStay.Value == 0)
                    {

                        dtpEndDate.Value = EndDate.AddDays(-1);
                        dtpStartDate.Value = StartDate.AddDays(-1);
                    }
                }
                //theReservation.LenghtOfStay = Convert.ToDecimal(lengthOfStay.Value);
                myValue = lengthOfStay.Value;

            }
            else
            {

                //decimal myValue;
                if (lengthOfStay.Value > myValue)
                {

                    //MessageBox.Show(lengthOfStay.Value.ToString() + ">" + myValue.ToString());
                    dtpEndDate.Value = EndDate.AddDays(1);

                }
                else
                {
                    if (lengthOfStay.Value == 0)
                    {
                        EndDate = dtpEndDate.Value.AddDays(-1);
                        StartDate = dtpStartDate.Value.AddDays(-1);
                        lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;

                        lengthOfStay.Value = 1;
                        LblPricePerNight = lengthOfStay.Value.ToString();
                        TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();

                        lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;


                    }
                    else
                    {
                        LblPricePerNight = lengthOfStay.Value.ToString();
                        TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();
                        dtpEndDate.Value = EndDate.AddDays(-1);
                    }
                }
                myValue = lengthOfStay.Value;
            }
        }

        private void lblReserveDays_Click(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            RoomRate = txtRate.Text;
            //MessageBox.Show(RoomId.ToString() + "twittdjfsal;kjas");
            //MessageBox.Show(RoomRate.ToString()+"nigger djsafl;jsadk");
            LblPricePerNight = RoomRate;
            LblNumOfNights = LengthOfStay.ToString();
            TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(theCustomerInfo.Id.ToString()+"fucker");

            if (txtCustomerName.ReadOnly)
            {

                AddCustomerForm frm = new AddCustomerForm();
                CustomerDataService custData = new CustomerDataService();
                CustomerInfo custInfo = new CustomerInfo();

                int custId = Convert.ToInt32(theCustomerInfo.Id);
                custInfo = custData.GetCustomerInfoById(custId);
                //MessageBox.Show(custInfo.Id.ToString());
                frm.SetCustomerInformation(custInfo);
                frm.editForm = true;
                frm.reference = this;
                //frm.SurName = CustomerName;
                frm.ShowDialog();


            }
            else
            {
                MessageBox.Show("Editng failed");
            }
            

        }

        private void btnRemoveCust_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure want to remove this customer from this reservation ", 
                "Removing Customer from Reservation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("customer has been removed from the reservation");
                //MessageBox.Show(resId.ToString());
                CustomerName = null;
                btnAddCustomer.Enabled = true;
                btnEditCustomer.Enabled = false;
                btnRemoveCust.Enabled = false;
                txtCustomerName.ReadOnly = false;


            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("cancelled");

 
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MessageBox.Show(txtCustomerName.Text);
                CustomerDataService customerDataService = new CustomerDataService();
                //CustomerInfo myCustomerInfo = new CustomerInfo();
                txtCustomerName.ReadOnly = true;
                TheCustomerInfo = customerDataService.GetCustomerInfoByName(txtCustomerName.Text);

                //theCustomerInfo = myCustomerInfo;
            }
        }
            
        private void btnStatementOfAccount_Click(object sender, EventArgs e)
        {
            
            FrmStateAccount frm = new FrmStateAccount();
            ReservationDataService resData = new ReservationDataService();
            MessageBox.Show(theCustomerInfo.Id.ToString());
            frm.LoadReport(Convert.ToInt32(theCustomerInfo.Id), EndDate);
            frm.referencefrm1 = this;
            frm.Show();
            
        }
    }
}
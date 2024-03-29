﻿using MySql.Data.MySqlClient;
using System;
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
        public MySqlConnection conn;
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
        private int isGroupFalse { get; set; }
        private int amountPaid { get; set; }
        public string myRoomNum { get; set; }
        public int cmbRate { get; set;  }
        public string RoomId { get; set; }
        public string EditName { get; set; }
        public double mainprice = 0.0F;
        #region
        //private bool CustomerInfoExist = false;
        public int CmbRate
        {
            set { cmbRate = value; }
            get { return cmbRate; }
        }

        public int IsGroup
        {
            set { isGroupFalse = value; }
            get { return isGroupFalse; }
        }

        public int AmountPaid
        {
            set { isGroupFalse = value; }
            get { return isGroupFalse; }
        }
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
        /*
        public string RoomId
        {
            set { txtRoomId.Text = value; }
            get { return txtRoomId.Text; }
        }
        */
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
        #endregion

        public AddReservationView()
        {

            InitializeComponent();
            // CustomerInfo _customerInfo = new CustomerInfo();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;SslMode=none;");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dtpStartDate.CustomFormat = "dd MMMM yyyy dddd";
            dtpEndDate.CustomFormat = "dd MMMM yyyy dddd";

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
        #region setting values
        public void setValuesBasedOnReservationId(RoomInfo customInfo, string roomType, string roomNumber, DateTime startDate, DateTime endDate, string description, int roomRate1, int isGrouped, int amtPaid)
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
            RoomRate = roomRate1.ToString();
            LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
            LblNumOfNights = LengthOfStay.ToString();
            LblPricePerNight = RoomRate.ToString();
            TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * (Convert.ToInt32(LblPricePerNight))).ToString();
            IsGroup = isGrouped;
            AmountPaid = amountPaid;
            //cmbRoomRate.Text = roomRate1.ToString();
           

            //TotalAccomadation = (Convert.ToInt32(LblReserveDays) * (Convert.ToInt32(LblPerNight))).ToString();

            lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            txtRate.TextChanged += txtRate_TextChanged;
        }
        #endregion

        #region set values by selection
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
        #endregion

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
        #region
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
            //ComboBox hello = elementHOs   
            List<RoomTextBoxItems> myRooms = new List<RoomTextBoxItems>();

            RoomDataService myRoomDataService = new RoomDataService();
            myRooms = myRoomDataService.getRoomInfoByType(cmbRoomType.Text);
            MessageBox.Show(cmbRoomType.Text);
            foreach(RoomTextBoxItems item in myRooms)
            { 
                cmbRoomNumber.Items.Add(item);
            }
            //RoomDataService 

        }
        
        public void LoadComboRoomRates()
        {
            List<string> myRates = new List<string>();

            RoomDataService myRoomDataService = new RoomDataService();
            //MessageBox.Show(RoomId.ToString());
            myRates = myRoomDataService.GetRoomRates(Convert.ToInt32(RoomId));
            foreach (var item in myRates)
            {
                //cmbRoomRate.Items.Add(item);
            }
            //RoomDataService 

        }
        
        private void LoadRoomTypeCombo()
        {
            //get combo box items
            // filter by type
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
        public void LoadHkAndCoffee(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT menuitem.id, name, sell_price " +
                    "FROM minventory JOIN menuItem " +
                    "ON product_id  = menuitem.id WHERE menuitem.type = '" + id+"'", conn);

                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show(id.ToString());
                    if (id == 0) dgvCoffeeView.DataSource = dt;
                    else if (id == 1) dgvHKView.DataSource = dt;

                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        #endregion
        #region Load Reservation
        private void AddReservation_Load(object sender, EventArgs e)
        {
            LoadHkAndCoffee(1);
            LoadHkAndCoffee(0);
            btnStatementOfAccount.Enabled = false;
           // txtRate.Text = "0.0";
            LoadCustomerNames();
            //btnAddCustomer.Visible = false;
            //if the form is in edit mode
            if (editForm)
            {
                btnStatementOfAccount.Enabled = true;
                // numeric up down Valuechanged event is removed before setting values
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
                txtRate.TextChanged -= txtRate_TextChanged;
                LoadRoomTypeCombo();

                LoadRoomComboBoxes();
                //LoadComboRoomRates();
                EditFormIsTrue();
                cmbRoomType.SelectedIndex = cmbRoomType.FindString(RoomType);
                //cmbRoomNumber.Text = RoomNumber.ToString();
                cmbRoomNumber.SelectedIndex = cmbRoomNumber.FindString(RoomNumber);


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

                LoadRoomTypeCombo();


                cmbRoomType.Text = RoomType;
                cmbRoomNumber.Text = RoomNumber.ToString();
                //LoadRoomComboBoxes();

                //LoadComboRoomRates();

                //cmbRoomRate.SelectedIndex = 0;

                /*
                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                LblPricePerNight = cmbRoomRate.Text;
                //TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();
                RoomRate = txtRate.Text;
                */


                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;

                // button disable
                btnEditCustomer.Enabled = false;
                btnDelete.Enabled = false;

            }
            else //if reservation creation is by selection 
            {
                //dtpEndDate.ValueChanged -= dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged -= dtpStartDate_ValueChanged;
                lengthOfStay.ValueChanged -= lengthOfStay_ValueChanged;
                //cmbRoomType.SelectedIndexChanged -= cmbRoomType_SelectedIndexChanged;

                LoadRoomTypeCombo();
                LoadRoomComboBoxes();
                MessageBox.Show("402");


                //LoadComboRoomRate();
                //cmbRoomType.SelectedIndex = RoomType;
                cmbRoomType.SelectedIndex = cmbRoomType.FindString(RoomType);
                //cmbRoomNumber.Text = RoomNumber.ToString();
                cmbRoomNumber.SelectedIndex = cmbRoomNumber.FindString(RoomNumber);

                LoadRoomComboBoxes();
                //LoadComboRoomRates();

                //cmbPerNight2.SelectedIndex = 1;

                LengthOfStay = (dtpEndDate.Value - dtpStartDate.Value).Days;
                LblNumOfNights = LengthOfStay.ToString();
                RoomRate = txtRate.Text;
                //TotalAccomadation = (Convert.ToInt32(LblNumOfNights) * Convert.ToInt32(LblPricePerNight)).ToString();

                //LblPricePerNight = cmbRoomRate.Text;

                lengthOfStay.ValueChanged += lengthOfStay_ValueChanged;
                dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
                dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
                //cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;


                //button
                btnEditCustomer.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        #endregion
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
                /*
                if(Convert.ToInt32(LblNumOfNights) == 0)
                {
                    LblNumOfNights = "0";
                }
                if (Convert.ToInt32(LblPricePerNight) == 0)
                {
                    LblPricePerNight = "0";

                }
                */
                //TotalAccomadation = (Convert.ToInt32(lblNumOfNights.Text) * Convert.ToInt32(lblPr.Text)).ToString();
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
            //string phrase = row.Cells[0].Value.ToString();
            //string[] words = .Split(' ');
            //if (words[0].Equals(searchValueRow))
            //string[] strRoomRate = cmbRoomRate.Text.Split(' ');
            //RoomRate = strRoomRate[0];

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
            //myReservation.CmbRate = Convert.ToInt32(RoomRate);
            return myReservation;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            person_counter = 0;
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
            #region If the form is in editing state
            if (EditForm) // if the form is in editing state perform an update
            {
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
                //else if (String.IsNullOrEmpty(cmbRoomRate.Text))
                //{
                //    MessageBox.Show("Missing room rate please fill it in");

                //}
                else
                {
                    // if txtCustomer is ReadOnly do not insert into Customer table just UPdate Reservation
                    if (txtCustomerName.ReadOnly)
                    {
                       ReservationDataService frm = new ReservationDataService();


                        //myCustomer.Name = CustomerName;
                        frm.UpdateReservation(theReservation.ResId, Convert.ToInt32(RoomId), Convert.ToInt32(theCustomerInfo.Id), Description,
                            StartDate, EndDate, 0, Convert.ToInt32(TotalAccomadation), Convert.ToInt32(LengthOfStay),
                            Convert.ToInt32(RoomRate));
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
            #endregion

            else if (emptyTextBox){
                MessageBox.Show("room data is empty please fill in room data");

            }
            else if (myResCalFor.ReservationCheckAdvanced(startDay, startMonth, startYear, endDay, endMonth, endYear, Convert.ToInt32(RoomId))>= 1)
            {
                MessageBox.Show("This is valid dates conflict with existing reservation");
            }
            else // new reservation has been made by reservation button or by selection
            {
                ReservationInfo reserveClass = new ReservationInfo();
                CustomerDataService customDataServ = new CustomerDataService();
                // Boolean occupied = true;

    

                //perform a search if duplicate customername is in database
                if (String.IsNullOrWhiteSpace(txtCustomerName.Text) || StartDate == null || EndDate == null)
                {
                    MessageBox.Show("there are missing fields please fill it in");
                }

                else // if reservation details are good
                {


                    //if a customer was selected from autocomplete
                    if (txtCustomerName.ReadOnly)
                    {
                        TestDataService frm = new TestDataService();
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

                        /*
                        frm.AddReservation(Convert.ToInt32(myReservation.RoomId), Convert.ToInt32(TheCustomerInfo.Id), myReservation.Desc,
                           myReservation.StartDate, myReservation.EndDate, 0, myReservation.TotalPrice, myReservation.LenghtOfStay, myReservation.RoomRate);
                           */
                        MessageBox.Show(StartDate.ToString());
                        MessageBox.Show(EndDate.ToString());

                        frm.AddReservation2nd(Convert.ToInt32(myReservation.RoomId), Convert.ToInt32(TheCustomerInfo.Id), myReservation.Desc,
                           myReservation.StartDate, myReservation.EndDate, 0, myReservation.TotalPrice, myReservation.LenghtOfStay, myReservation.RoomRate);
                        
                     //frm.verifyCustomerInfoAndCreateReservation(myCustomer, myRe2nservation, referencefrm1);

                     this.Close();
                        this.Dispose();
                        referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                        referencefrm1.Show();
                    }
                    /*
                    else if (duplicatesTable.Rows.Count == 1)
                    {
                        MessageBox.Show("This name conflicts with another person name please try another");
                    }
                    */
                    else //if a new customer added
                    {
                        ReservationDataService frm = new ReservationDataService();
                        CustomerInfo myCustomer = new CustomerInfo();
                        ReservationInfo myReservation = new ReservationInfo();

                        myReservation = SettingReservationInfo();
                        myCustomer.Name = CustomerName;
                        MessageBox.Show("751 is here");
                        List<string> persons = new List<string>();
                          

                        
                        
                        int i = frm.verifyCustomerInfoAndCreateReservation(myCustomer, myReservation, referencefrm1);
                        foreach (DataGridViewRow row in dgvViewPersons.Rows)
                        {
                            
                            //.Show(row.Cells[0].Value.ToString()); 
                            if (row.Cells[1].Value.ToString().Equals("YES"))
                            {
                                int idPerson = 1;
                                AddPerson2(row.Cells[0].Value.ToString(), idPerson.ToString(), i.ToString());
                            }
                            else
                            {
                                int idPerson = 2;
                                AddPerson2(row.Cells[0].Value.ToString(), idPerson.ToString(), i.ToString());

                            }
                        }


                        this.Close();

                        this.Dispose();
                        referencefrm1.displayReservationButt(dgvMonth, dgvYear);

                        referencefrm1.Show();
                    }


                }

            }
        }
        public void AddPerson2(string p, string id, string reserve)
        {
            try
            {
                conn.Open();
                //MySqlCommand command = new MySqlCommand("INSERT into customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace, comment) values('" + SurName.Text + "','" + company.Text + "','" + address.Text + "','" + phone.Text + "','" + email.Text + "','" + passport.Text + "','" + nationality.Text + "','" + gender.Text + "','" + bdate.Value.ToString("yyyy-MM-dd") + "','" + bplace.Text + "','" + comment.Text + "')", conn);

                MySqlCommand command = new MySqlCommand("INSERT into add_person(person, addpersontype_id, reservation_id)" +
                    " VALUES('" + p + "', '" + id + "','" + reserve + "')", conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }

        }
        public void AddPerson(string p, string id, string reserve)
        {
            try
            {
                conn.Open();
                //MySqlCommand command = new MySqlCommand("INSERT into customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace, comment) values('" + SurName.Text + "','" + company.Text + "','" + address.Text + "','" + phone.Text + "','" + email.Text + "','" + passport.Text + "','" + nationality.Text + "','" + gender.Text + "','" + bdate.Value.ToString("yyyy-MM-dd") + "','" + bplace.Text + "','" + comment.Text + "')", conn);

                MySqlCommand command = new MySqlCommand("INSERT into add_person(person, addpersontype_id, reservation_id)" +
                    " VALUES('" + p + "', '" + id + "','" + reserve + "')", conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm frm = new AddCustomerForm();
            frm.reference = this;
            frm.SurName.Text = txtCustomerName.Text;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtCustomerName.Text = frm.SurName.Text;
                txtCustomerName.ReadOnly = true;
                btnEditCustomer.Enabled = true;
                btnRemoveCust.Enabled = true;


            }
            else
            {
                MessageBox.Show("passed here");
                txtCustomerName.ReadOnly = false;

            }

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

            //cmbRoomRate.Items.Clear();
            //cmbRoomRate.Text = null;
            RoomDataService myRoomDataService = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();
            myRoomInfo = myRoomDataService.getRoomInfoByRoomNumber(cmbRoomNumber.Text);
            RoomId = myRoomInfo.RoomId;
            //LoadComboRoomRates();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbRoomNumber.Text = null;
            cmbRoomNumber.Items.Clear();
            cmbRoomNumber.Text = null;
            //cmbRoomRate.Items.Clear();
            //cmbRoomRate.Text = null;
            //MessageBox.Show("over here boi 825 address");
            LoadRoomComboBoxes();
            getRoomRate();
            btnAddPerson.Enabled = true;
        }

        public void getRoomRate()
        {
            cbPartners.Items.Clear();
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select * From room_rate JOIN room_type ON room_type_id = room_type.id WHERE room_type.roomType ='"+ cmbRoomType.Text +"'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtDefRoomRate.Text = dt.Rows[0]["rate"].ToString();
                    //cbPartners.Items.Add("");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if(dt.Rows[i]["request"].ToString() != "Default") cbPartners.Items.Add(dt.Rows[i]["request"].ToString());
                    }
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        // update fileds after picking room type
        private void txtDefRoomRate_TextChanged(object sender, EventArgs e)
        {
            txtRate.Text = txtDefRoomRate.Text;
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

                EditCustomerForm frm = new EditCustomerForm();
                CustomerDataService custData = new CustomerDataService();
                CustomerInfo custInfo = new CustomerInfo();

                int custId = Convert.ToInt32(theCustomerInfo.Id);
                frm.currID = custId;
                custInfo = custData.GetCustomerInfoById(custId);
                //MessageBox.Show(custInfo.Id.ToString());
                //frm.SetCustomerInformation(custInfo);
                //frm.editForm = true;
                frm.reference = this;
                //frm.SurName = CustomerName;
                frm.ShowDialog();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCustomerName.Text = frm.SurName.Text;
                    txtCustomerName.ReadOnly = true;
                    btnEditCustomer.Enabled = true;
                    btnRemoveCust.Enabled = true;
                    EditName = frm.SurName.Text;



                }
                else
                {
                    MessageBox.Show("passed here");
                    txtCustomerName.ReadOnly = false;

                }


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
            //MessageBox.Show(theCustomerInfo.Id.ToString());
            frm.LoadReport(theReservation.ResId);
            frm.referencefrm1 = this;
            frm.Show();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                // Do something...
            }
            */
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbRoomType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPerNight2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRoomRate frm2 = new AddRoomRate();
            frm2.referencefrm1 = this;
            frm2.ShowDialog();
            /*
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("INSERT into customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace, comment) values('" + SurName.Text + "','" + company.Text + "','" + address.Text + "','" + phone.Text + "','" + email.Text + "','" + passport.Text + "','" + nationality.Text + "','" + gender.Text + "','" + bdate.Value.ToString("yyyy-MM-dd") + "','" + bplace.Text + "','" + comment.Text + "')", conn);
                //int id = (int)command.ExecuteScalar();
                if (command.ExecuteNonQuery() == 1) MessageBox.Show("Data Inserted");
                else MessageBox.Show("Data not inserted");
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
            this.DialogResult = DialogResult.OK;
            */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddReservationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            referencefrm1.Show();
        }

        private void roomPriceControl_TabIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(""+ roomPriceControl.SelectedIndex);
            //if(roomPriceControl.SelectedIndex == 0) txtRate.Text = txtDefRoomRate.Text;
            //else if (roomPriceControl.SelectedIndex == 1) txtRate.Text = txtPRoomRate.Text;
        }
        #region room price control
        private void roomPriceControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPartners.SelectedIndex = 1;
            if (roomPriceControl.SelectedIndex == 0)
            {
                txtRate.Text = txtDefRoomRate.Text;
                mainprice = Convert.ToDouble(txtDefRoomRate.Text);
                txtRate.Text = (mainprice + Convert.ToDouble(addPersonAmount.Text)).ToString();
            }
            else if (roomPriceControl.SelectedIndex == 1)
            {
                txtRate.Text = txtPRoomRate.Text;
                mainprice = Convert.ToDouble(txtPRoomRate.Text);
                txtRate.Text = (mainprice + Convert.ToDouble(addPersonAmount.Text)).ToString();
            }
        }
        #endregion
        //get price where request is equal to bla bla 
        private void cbPartners_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPriceFromRequest();
            mainprice = Convert.ToDouble(txtPRoomRate.Text);
            txtRate.Text = (mainprice + Convert.ToDouble(addPersonAmount.Text)).ToString();
        }

        public void getPriceFromRequest()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select rate From room_rate JOIN room_type ON room_type_id = room_type.id  WHERE request = '" + cbPartners.Text + "' AND roomType = '" + cmbRoomType.Text + "'", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtPRoomRate.Text = dt.Rows[0]["rate"].ToString();
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        //update price details after choosing a pertner or reqeust from 
        private void txtPRoomRate_TextChanged(object sender, EventArgs e)
        {
            txtRate.Text = txtPRoomRate.Text;
        }

        #region add person with or without ammenities
        public int person_counter = 0;
        public int personTotal = 0;
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { };
            person_counter++;
            string p = "Person " + person_counter;
            amenity am = new amenity();
            am.adv = this;
            if(am.ShowDialog() == DialogResult.OK)
            {
                if (am.rbTrue.Checked) row = new string[] { p, "YES", personPrice(1) };
                else if (am.rbFalse.Checked) row = new string[] { p, "NO", personPrice(0) };
                dgvViewPersons.Rows.Add(row);
                personTotal = personTotal + Convert.ToInt32(row[2]);
                addPersonAmount.Text = personTotal.ToString();
                txtRate.Text = (Convert.ToInt32(txtRate.Text) + Convert.ToInt32(row[2])).ToString();
            }
                
        }

        public string personPrice(int i)
        {
            string yesorno = "";
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select price FROM addpersontype WHERE amenities = "+ i +"", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    yesorno = dt.Rows[0]["price"].ToString();
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
            return yesorno;
        }

        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            int index;
            if (dgvViewPersons.Rows.Count != 0) { 
                index = dgvViewPersons.CurrentCell.RowIndex;
                txtRate.Text = (Convert.ToInt32(txtRate.Text) - Convert.ToInt32(dgvViewPersons.SelectedRows[0].Cells[2].Value.ToString())).ToString();
                addPersonAmount.Text = (Convert.ToInt32(addPersonAmount.Text) - Convert.ToInt32(dgvViewPersons.SelectedRows[0].Cells[2].Value.ToString())).ToString();
                personTotal = personTotal - Convert.ToInt32(dgvViewPersons.SelectedRows[0].Cells[2].Value.ToString());
                //MessageBox.Show(viewPersons.SelectedRows[0].Cells[0].Value.ToString());
                dgvViewPersons.Rows.RemoveAt(index);
            }
        }

        #endregion

        private void lblTotalAccomadation_TextChanged(object sender, EventArgs e)
        {
            lblAmoutTotal.Text = lblTotalAccomadation.Text;
        }
        public int hkCounter = 0;
        private void LoadData(int id)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("Select * From billing JOIN menuitem " +
                    " ON billing.menuitem_id = menuitem.id JOIN minventory ON menuitem.id = " +
                    " minventory.product_id WHERE menuitem.type ='"+id+"' ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvHKAdd.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah! " + ee);
                conn.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvHKView.SelectedRows[0].Cells[0].Value.ToString());
                DateTime dtNow = DateTime.Now;

                string query = "INSERT INTO Billing(menuitem_id, quantity, datetime) " +
                    "VALUES('" + id + "','" + hkCounter++ + "','" + dtNow.ToString("yyyy-MM-dd")+ 
                    "')";
                conn.Open();
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                conn.Close();

                MessageBox.Show(ex.ToString());
            }
            LoadData(1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(tbRes.SelectedIndex.ToString());
            if(tbRes.SelectedIndex == 1)
            {
                LoadHkAndCoffee(0);

            }
            else if(tbRes.SelectedIndex == 2)
            {
                LoadHkAndCoffee(1);

            }


        }
    }
}

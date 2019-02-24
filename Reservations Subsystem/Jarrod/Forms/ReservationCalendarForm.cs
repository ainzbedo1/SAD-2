using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Windows.Documents;

namespace Reservations_Subsystem
{
    public partial class ReservationCalendarForm : Form
    {
        //public ViewRoom referenceViewRoom { get; set; }
        //public AddReservation AddReservationForm { get; set; }
        public MySqlConnection conn;
        public AddReservationView reference { get; set; }
        public string[] monthString = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int buttonCreateCounter = 0;
        public event EventHandler OnShowReservationInfo;
        public ReservationCalendarForm()
        {

            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");


        }

        #region
        public DataGridView displayCalendar(int month, int year)
        {
           
            string nowdate = "01/" + month + "/" + year;
            DateTime datetime = DateTime.ParseExact(nowdate, "d/M/yyyy", CultureInfo.InvariantCulture);

    
            DataTable dt = new DataTable();

            for (int i = 1; i <= DateTime.DaysInMonth(datetime.Year, datetime.Month) + 2; i++)
            {
                if (i == 1)
                {
                    dt.Columns.Add("");
                }
                else if (i != DateTime.DaysInMonth(datetime.Year, datetime.Month) + 2)
                {
                    dt.Columns.Add(datetime.AddDays(i - 2).ToString("ddd") + " " + (i - 1) + "");


                }
            }

            string query = "SELECT roomNumber FROM room";
            using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
            {
                try
                {
                    DataTable dgvhello = new DataTable();
                    blah.Fill(dgvhello);
                    
                    //calendar.Rows.Add(hello.Rows.Count);
                    for (int i = 0; i < dgvhello.Rows.Count; i++)
                    {
                        dt.Rows.Add();
                    }
                    int newColumnIndex = 0;
                    // get an index of the Amount column in your other dgv
                    var index = dgvhello.Columns["roomNumber"].Ordinal;
                    // copy all items from dgv1 in that column to new column in dgv2
                    //calendar.Rows.Add(dbRoom.Rows.Count);
                    calendar.DataSource = dt;
                    for (int i = 0; i < dgvhello.Rows.Count; i++)
                    {
                        calendar.Rows[i].Cells[newColumnIndex].Value = dgvhello.Rows[i].Field<string>(0).ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            
            foreach (DataGridViewColumn blah in calendar.Columns)
            {
                blah.Width = 40;
            }
            calendar.Columns[0].Width = 100;
            calendar.Columns[0].Name = "Rooms";
            calendar.Columns[0].HeaderText = "Rooms";
            calendar.RowHeadersVisible = false;
            calendar.Columns[0].ReadOnly = true;
            
            calendar.Columns[0].DefaultCellStyle.BackColor = Color.Gray;
            calendar.ReadOnly = true;
            return calendar;
        }
        #endregion //display calendar

        private void Form1_Load(object sender, EventArgs e)
        {
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);

            calendar.ClearSelection();
            this.button2.Click += new EventHandler(myButtonHandler_SingleClick);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            displayReservationButt(month, year);
        }

        private void calendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            int monthprev = Array.IndexOf(monthString, btnPrevMonth.Text);
            if (monthprev == 0)
            {
                btnNextMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnPrevMonth.Text;
                btnPrevMonth.Text = monthString[11];


            }
            else
            {
                btnNextMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnPrevMonth.Text;
                btnPrevMonth.Text = monthString[monthprev - 1];
            }
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            int monthnext = Array.IndexOf(monthString, btnNextMonth.Text);
            if (monthnext == 11)//December
            {
                btnPrevMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnNextMonth.Text;
                btnNextMonth.Text = monthString[0];



            }
            else
            {
                btnPrevMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnNextMonth.Text;
                btnNextMonth.Text = monthString[monthnext + 1];
            }
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
        }

        private void mainYearBTN_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevYear_Click(object sender, EventArgs e)
        {
            btnMainYear.Text = (Int32.Parse(btnMainYear.Text) - 1).ToString();
            btnNextYear.Text = (Int32.Parse(btnNextYear.Text) - 1).ToString();
            btnPrevYear.Text = (Int32.Parse(btnPrevYear.Text) - 1).ToString();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);

        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            btnMainYear.Text = (Int32.Parse(btnMainYear.Text) + 1).ToString();
            btnNextYear.Text = (Int32.Parse(btnNextYear.Text) + 1).ToString();
            btnPrevYear.Text = (Int32.Parse(btnPrevYear.Text) + 1).ToString();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);

        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {


        }
        private void ShowAddReservationForm()
        {
            AddReservationView frm2 = new AddReservationView();
            frm2.referencefrm1 = this;
            frm2.Show();

        }
        //2/13/2019 10:39 AM
        /*
        string iDate = "05/05/2005";
        DateTime oDate = Convert.ToDateTime(iDate);
        MessageBox.Show(oDate.Day + " " + oDate.Month + "  " + oDate.Year );
        */
        //Formats string 
        private DateTime DateFormat(string Day)
        {
            try
            {

                //int getMonth = Array.IndexOf(monthString, btnMainMonth.Text);
                string getmonth = btnMainMonth.Text;
                //string monthNow = getM2341onth.ToString("D2");
                int yearNow = Convert.ToInt32(btnMainYear.Text);

                //Formating day into 02, 11, 09 format 
                string dayNow = new String(Day.Where(Char.IsDigit).ToArray());
                int dayNowInt = Convert.ToInt32(dayNow);
                string dayNowIntFormatted = dayNowInt.ToString("D2");

                string finalDateFormat = dayNowIntFormatted.ToString() + "/" + getmonth.ToString() + "/" + yearNow.ToString();

                DateTime dateTimeConvert = Convert.ToDateTime(finalDateFormat);
                return dateTimeConvert;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return DateTime.Now;
            }
        }
        
        //creates a button based on date given
        // startDate - endDate is width
        // remember to handle if dates go over a month handle month first
        // position is based of room row location
        // find centerOfStartdate

        private void SelectionOnDgvCalendar(List<int> rowIndexes, List<int> columnIndexes)
        { 
            if (columnIndexes.Min() == 0)
            {
                MessageBox.Show("this selection is not allowed");
                calendar.ClearSelection();
            }

            // If amount of rows selected is only equal to 1 
            // handles both left to right and right to left selection
            else if (rowIndexes.Max() - rowIndexes.Min() == 0)
            {
                List<ReservationInfo> myReservationList = new List<ReservationInfo>();
                ReservationDataService reservationDataService = new ReservationDataService();
                ReservationInfo resInfo = new ReservationInfo();

                //this is last cell location 
                int firstRowIndex = rowIndexes.Max();
                int firstColumnIndex = columnIndexes.Max();

                //this first cell location
                int lastRowIndex = rowIndexes.Min();
                int lastColumnIndex = columnIndexes.Min();

                //Right side last index
                //only getting y
                int x1, y1;
                x1 = this.calendar.GetCellDisplayRectangle(firstColumnIndex,
                firstRowIndex, false).Right + calendar.Left;
                y1 = this.calendar.GetCellDisplayRectangle(firstColumnIndex,
                firstRowIndex, false).Top + calendar.Top;

                 //getting leftmost pixel of first cell and right most
                int firstLeftCellX, firstRightCellX;
                firstLeftCellX = this.calendar.GetCellDisplayRectangle(lastColumnIndex,
                lastRowIndex, false).Left + calendar.Left;

                firstRightCellX = this.calendar.GetCellDisplayRectangle(lastColumnIndex,
                lastRowIndex, false).Right + calendar.Left;
                //createButton(firstLeftCellX, y1);

                int centerPointFirstCell = (firstRightCellX + firstLeftCellX) / 2;

                //int middleLocationX, int middleLocationY, int width, int height for creation of button
                //method for this is below createButton overload
                int totalWidth = (this.calendar.SelectedCells.Count * 40) - 40;
                //createButton(centerPointFirstCell, y1, totalWidth, 20);
                
                //get column headers of first cell and last cell of selection
                string firstDateReservation = calendar.Columns[lastColumnIndex].HeaderText;
                string lastDateReservation = calendar.Columns[firstColumnIndex].HeaderText;
                
               

                AddReservationView frm = new AddReservationView();

                frm.referencefrm1 = this;
                frm.RoomNumber = calendar.Rows[rowIndexes.Min()].Cells["rooms"].Value.ToString();
                frm.StartDate = DateFormat(firstDateReservation);
                frm.EndDate = DateFormat(lastDateReservation);

                int startDay = DateFormat(firstDateReservation).Day;
                int endDay = DateFormat(firstDateReservation).Day;

                int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
                int reservationIntefere = ReservationCheck(Convert.ToInt32(startDay), Convert.ToInt32(endDay), month, year, Convert.ToInt32(frm.RoomNumber));
                if(reservationIntefere == 1)
                {
                    MessageBox.Show("Selection is not allowed here reservation have confliciting dates");
                    
                }
                else
                {


                    RoomDataService why = new RoomDataService();
                    Boolean edit = false;
                    //editing is false
                    ReservationDataPresenter data = new ReservationDataPresenter(frm, why);
                    data.Show();
                }

               // SelectionBlockingByResDates(Convert.ToInt32(firstDateReservation), Convert.ToInt32(lastDateReservation), month, year, Convert.ToInt32(frm.RoomNumber));
                //Setting up frm2 values 



                
            }
            //handles if mutiple rows were selected
            else if (rowIndexes.Max() + rowIndexes.Min() > 0)
            {
                MessageBox.Show((rowIndexes.Max() - rowIndexes.Min()).ToString());
                int amountOfRows = rowIndexes.Max() - rowIndexes.Min(); //amount buttons to create
                for (int i = 0; i <= amountOfRows; i++)
                {
                    //this is last cell location 
                    // 0, 11 not 1, 11
                    //MessageBox.Show(distinctRowIndexes.Count.ToString());
                    int firstRowIndex = rowIndexes[i];
                    int firstColumnIndex = columnIndexes.Max();

                    //this first cell location
                    int lastRowIndex = rowIndexes[i];
                    int lastColumnIndex = columnIndexes.Min();

                    //Right side last index
                    //only getting y
                    int x1, y1;
                    x1 = calendar.GetCellDisplayRectangle(firstColumnIndex,
                    firstRowIndex, false).Right + calendar.Left;
                    y1 = calendar.GetCellDisplayRectangle(firstColumnIndex,
                    firstRowIndex, false).Top + calendar.Top;




                    //getting leftmost pixel of first cell and right most
                    int firstLeftCellX, firstRightCellX;
                    firstLeftCellX = calendar.GetCellDisplayRectangle(lastColumnIndex,
                    lastRowIndex, false).Left + calendar.Left;

                    firstRightCellX = calendar.GetCellDisplayRectangle(lastColumnIndex,
                    lastRowIndex, false).Right + calendar.Left;
                    //createButton(firstLeftCellX, y1);

                    int centerPointFirstCell = (firstRightCellX + firstLeftCellX) / 2;




                    //int middleLocationX, int middleLocationY, int width, int height for creation of button
                    //method for this is below createButton overload
                    int totalWidth = ((columnIndexes.Max() - columnIndexes.Min()) * 40);
                    //createButton(centerPointFirstCell, y1, totalWidth, 20);
   
                }

            }

        }
    

        private void calendar_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<int> rowIndexes = new List<int>();
                List<int> columnIndexes = new List<int>();
                if (calendar.Columns[0].Selected)
                {
                    MessageBox.Show("Selection here is not allowed");
                    calendar.ClearSelection();
                }

                Int32 selectedCellCount = calendar.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (calendar.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        System.Text.StringBuilder sb =
                            new System.Text.StringBuilder();

                     
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            rowIndexes.Add(calendar.SelectedCells[i].RowIndex);
                            columnIndexes.Add(calendar.SelectedCells[i].ColumnIndex);

                        }


                    }
                }
                List<int> distinctRowIndexes = rowIndexes.Distinct().ToList();
                List<int> distinctColumnIndexes = columnIndexes.Distinct().ToList();
                SelectionOnDgvCalendar(distinctRowIndexes, distinctColumnIndexes);
            }
        }        
        private void button2_Click(object sender, EventArgs e)
        {



        }


        public void findFirstcell(DateTime startDate, DateTime endDate, long reserveId, string roomId)
        {

            try
            {
                //initialization
                //DataGridView myDgv = new DataGridView();
                ReservationCalendarForm resCalendar = new ReservationCalendarForm();
                ReservationDataService myDataService = new ReservationDataService();
                RoomInfo roomInfo = new RoomInfo();

                RoomDataService roomDataService = new RoomDataService();

                // initializing search values
                MessageBox.Show(roomId);
                roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));
               
                string searchValueRow = roomInfo.RoomNumber;
                MessageBox.Show("My search value is" + searchValueRow);
                string searchValueColumn = startDate.Day.ToString();
                int rowIndex = -1;
                //int columnIndex = -1;

                //getting row index for y
                foreach (DataGridViewRow row in calendar.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }


                }
                // need to find location of startdate in datagridview
                int columnIndex = startDate.Day;


                int y1;
                y1 = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Top + calendar.Top;

                //getting leftmost pixel of starting cell and right most pixela
                int firstLeftCellX, firstRightCellX;
                firstLeftCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Left + calendar.Left;

                firstRightCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Right + calendar.Left;

                int centerPointFirstCell = (firstRightCellX + firstLeftCellX) / 2;

                // getting timespan of whole date
                TimeSpan stayInDays = endDate - startDate;
                int totalWidth = (stayInDays.Days * 40);
                string name = Convert.ToString(reserveId);


                createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void FindFirstButtBackFlow(DateTime startDate, DateTime endDate, long reserveId, string roomId)
        {

            //DataGridView myDgv = new DataGridView();
            ReservationCalendarForm resCalendar = new ReservationCalendarForm();
            ReservationDataService myDataService = new ReservationDataService();
            RoomInfo roomInfo = new RoomInfo();

            RoomDataService roomDataService = new RoomDataService();
            AddReservationView frmView = new AddReservationView();

            // initializing search values
            roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));
            string searchValueRow = roomInfo.RoomNumber;
            MessageBox.Show("My search value is" + searchValueRow);
            string searchValueColumn = startDate.Day.ToString();
            int rowIndex = -1;
            //int columnIndex = -1;

            //getting row index for y
            foreach (DataGridViewRow row in calendar.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
  

            }
            // need to find location of startdate in datagridview
            int columnIndex = 1;


            int y1;
            y1 = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Top + calendar.Top;

            //getting leftmost pixel of starting cell and right most pixela
            int firstLeftCellX, firstRightCellX;
            firstLeftCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Left + calendar.Left;

            firstRightCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Right + calendar.Left;

            int centerPointFirstCell = firstLeftCellX;

            //check the endDate days
            int daysAtEnd = endDate.Day;
            int totalWidth = (daysAtEnd * 40);
            string name = Convert.ToString(reserveId);


            createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));

        }


        //  if reservation starts on the month now but ends on a later month
        public void FindFirstButtFrontFlow(DateTime startDate, DateTime endDate, long reserveId, string roomId)
        {
            try
            {
                //initialization
                //DataGridView myDgv = new DataGridView();
                ReservationCalendarForm resCalendar = new ReservationCalendarForm();
                ReservationDataService myDataService = new ReservationDataService();
                RoomInfo roomInfo = new RoomInfo();

                RoomDataService roomDataService = new RoomDataService();

                // initializing search values
                MessageBox.Show(roomId);
                roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));

                string searchValueRow = roomInfo.RoomNumber;
                MessageBox.Show("My search value is" + searchValueRow);
                string searchValueColumn = startDate.Day.ToString();
                int rowIndex = -1;
                //int columnIndex = -1;

                //getting row index for y
                foreach (DataGridViewRow row in calendar.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }


                }
                // need to find location of startdate in datagridview
                int columnIndex = startDate.Day;
                MessageBox.Show(startDate.Day.ToString());
                MessageBox.Show(rowIndex.ToString() + "my row index " + columnIndex.ToString());

                int y1;
                y1 = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Top + calendar.Top;

                //getting leftmost pixel of starting cell and right most pixela
                int firstLeftCellX, firstRightCellX;
                firstLeftCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Left + calendar.Left;

                firstRightCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
                rowIndex, false).Right + calendar.Left;

                int centerPointFirstCell = (firstRightCellX + firstLeftCellX) / 2;

                // getting timespan of whole date
                int stayInDays = startDate.Day;
                int totalWidth = 20;
                string name = Convert.ToString(reserveId);


                createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void FindFirstButtDoubleOverFlow(DateTime startDate, DateTime endDate, long reserveId, string roomId)
        {

            //DataGridView myDgv = new DataGridView();
            ReservationCalendarForm resCalendar = new ReservationCalendarForm();
            ReservationDataService myDataService = new ReservationDataService();
            RoomInfo roomInfo = new RoomInfo();

            RoomDataService roomDataService = new RoomDataService();
            AddReservationView frmView = new AddReservationView();

            // initializing search values
            roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));
            string searchValueRow = roomInfo.RoomNumber;
            MessageBox.Show("My search value is" + searchValueRow);
            string searchValueColumn = startDate.Day.ToString();
            int rowIndex = -1;
            //int columnIndex = -1;

            //getting row index for y
            foreach (DataGridViewRow row in calendar.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
                else
                {
                    MessageBox.Show("error in button creation");
                }

            }
            // need to find location first datagridview cell that reservation occurs in
            int columnIndex = 1;


            int y1;
            y1 = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Top + calendar.Top;

            //getting leftmost pixel of starting cell and right most pixela
            int firstLeftCellX, firstRightCellX;
            firstLeftCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Left + calendar.Left;

            firstRightCellX = this.calendar.GetCellDisplayRectangle(columnIndex,
            rowIndex, false).Right + calendar.Left;

            int centerPointFirstCell = firstRightCellX;
            //check the endDate days

            // aka if reservation starts on the month now but ends on a later month
            int overFlow = endDate.Day;
            int totalWidth = overFlow * 40;
            string name = Convert.ToString(reserveId);


            createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));

        }


        public virtual void createButton(int centerPointFirstCell, int y1, int totalWidth, int reserveId, int roomId)
        {
            buttonCreateCounter++;
            //Button new_Button = new Button();
            MyButton dynamicButton = new MyButton();
            //dynamicButton.Location = new Point(1, 1);
            //dynamicButton.Location = new Point(545, 470);
            dynamicButton.Location = new Point(centerPointFirstCell, y1);
            dynamicButton.Height = 20;
            dynamicButton.Width = totalWidth;
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Text = "dfasfa";
            dynamicButton.Name = reserveId.ToString();
            dynamicButton.roomId = roomId;
            dynamicButton.Font = new Font("Georgia", 16);
            dynamicButton.Click += new EventHandler(myButtonHandler_SingleClick);
          
            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();
           
        }
       
 

        //this method gives the new buttons functionality
        public void myButtonHandler_SingleClick(Object sender, EventArgs e)
        {
            //'VERIFYING THE BUTTONS
            if (sender is MyButton)
            {
                try
                {

                    MyButton myButton = new MyButton();
                    myButton = sender as MyButton;
                    //MessageBox.Show(myButton.Name);
                    //MessageBox.Show(myButton.roomId.ToString());
                    AddReservationView theFrmView = new AddReservationView();
                    ReservationInfo myResInfo = new ReservationInfo();
                    RoomInfo myRoomInfo = new RoomInfo();
                    CustomerInfo myCustomerInfo = new CustomerInfo();

                    ReservationDataService reservationDataService = new ReservationDataService();
                    RoomDataService roomDataService = new RoomDataService();
                    CustomerDataService customerDataService = new CustomerDataService();

                    
                    theFrmView.referencefrm1 = this;
                    myResInfo = reservationDataService.GetReservationInfoById(Convert.ToInt32(myButton.Name));
                    int myRoomId = Convert.ToInt32(myResInfo.RoomId);
                    myRoomInfo = roomDataService.getRoomInfoById(myRoomId);
                    int myCustomerId = myResInfo.CustomerId;
                    MessageBox.Show(myCustomerId.ToString() + "what happend");
                    myCustomerInfo = customerDataService.GetCustomerInfoById(myCustomerId);
                    MessageBox.Show(myCustomerInfo.Name.ToString() + "what happend");
                    ReservationDataPresenter data = new ReservationDataPresenter(theFrmView, myResInfo, myRoomInfo, myCustomerInfo);
                    data.Show();
                    /*
                    theFrmView.referencefrm1 = this;
                    theFrmView.Show();
                    this.Hide();
                    */
                    /*
                     *AddReservationView frm = new AddReservationView();
                //MessageBox.Show(calendar.Rows.Count.ToString()+"WEFSDASDA");
                frm.referencefrm1 = this;
                frm.RoomNumber = calendar.Rows[rowIndexes.Min()].Cells["rooms"].Value.ToString();
                frm.StartDate = DateFormat(firstDateReservation);
                frm.EndDate = DateFormat(lastDateReservation);
                RoomDataService why = new RoomDataService();
                ReservationDataPresenter data = new ReservationDataPresenter(frm, why);
                data.Show();
                     */
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
              

            }
        }





        private void calendar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void calendar_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ViewRoom frm2 = new ViewRoom();
            frm2.referencefrm1 = this;
            frm2.Show();
            this.Hide();
        }

        private void calendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int currentCellRow = calendar.CurrentCell.RowIndex;
                int currentCellColumn = calendar.CurrentCell.ColumnIndex+1;

                // Set the current cell to the cell in column 1, Row 0. 
                this.calendar.CurrentCell = this.calendar[currentCellColumn, currentCellRow];


            }
 
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomer viewCustomerForm = new ViewCustomer();
            viewCustomerForm.referencefrm1 = this;
            viewCustomerForm.Show();
            this.Hide();
        }

        private void calendar_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataGridView myDgv = new DataGridView();
            ReservationCalendarForm resCalendar = new ReservationCalendarForm();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            myDgv = resCalendar.displayCalendar(month, year);
            MessageBox.Show(myDgv.Columns[0].HeaderText.ToString());

        }
        

        // if user tries to select on the dgv where a reservation already exists 
        public int ReservationCheck(int startDay, int endDay, int month, int year, int roomId)
        {
            
            // classes initialized
            List<ReservationInfo> myReservationList = new List<ReservationInfo>();
            List<DateTime> myDates = new List<DateTime>();
            RoomDataService roomDataService = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();
            ReservationDataService reservationDataService = new ReservationDataService();

            // initalize fields
            int storeEndDate = DateTime.DaysInMonth(year, month);
            DateTime firstSelectedDateOnDgv, lastSelectedDateOnDgv;
            string strStartDate, strEndDate;

            //formating string for conversions to DateTime
            string paddingTime = "12:00:00";

            // fomatting month now and startday and endDay
            string strStartDay, strEndDay;
            if (startDay < 10)
            {
                strStartDay = "0" + startDay.ToString();
            }
            else
            {
                strStartDay = startDay.ToString();
            }

            if (endDay < 10)
            {
                strEndDay = "0" + endDay.ToString();
            }
            else
            {
                strEndDay = endDay.ToString();
            }

            if (month < 10)
            {
                strStartDate = year + "-0" + month + "-" + strStartDay + " " + paddingTime;
                strEndDate = year + "-0" + month + "-" + strEndDay+ " " + paddingTime;
            }

            else
            {
                strStartDate = year + "-" + month + "-" + strStartDay + " " + paddingTime;
                strEndDate = year + "-" + month + "-" + strEndDay + " " + paddingTime;
            }
            


            // string strStartDate = "01/" + month + "/" + year + " ";
            // string strEndDate = "31/" + month + "/" + year + " ";
            //int storeEndDate = DateTime.DaysInMonth(year, month);
            //DateTime datetime = DateTime.ParseExact(nowdate, "d/M/yyyy", CultureInfo.InvariantCulture);
            //endDate = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            firstSelectedDateOnDgv = DateTime.ParseExact(strStartDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            lastSelectedDateOnDgv = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            myReservationList = reservationDataService.FilterReservationByDgvDate(firstSelectedDateOnDgv, lastSelectedDateOnDgv, roomId);
            return myReservationList.Count();

        }
        public void displayReservationButt(int month, int year)
        {
            List<ReservationInfo> myReservationList = new List<ReservationInfo>();
            ReservationDataService reservationDataService = new ReservationDataService();
            ReservationInfo resInfo = new ReservationInfo();
            DateTime startDateOnDGV, endDateOnDGV;
            RoomDataService roomDataService = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();

            //
            int storeEndDate = DateTime.DaysInMonth(year, month);
            string strStartDate, strEndDate;
            string paddingTime = "12:00:00";

            // if month now on the datagridview is less than 10
            if (month < 10)
            {
                strStartDate = year + "-0" + month + "-" + "01" + " " + paddingTime;
                strEndDate = year + "-0" + month + "-" + storeEndDate.ToString() + " " + paddingTime;
            }

            else
            {
                strStartDate = year + "-" + month + "-" + "01" + " " + paddingTime;
                strEndDate = year + "-" + month + "-" + storeEndDate.ToString() + " " + paddingTime;
            }


            // string strStartDate = "01/" + month + "/" + year + " ";
            // string strEndDate = "31/" + month + "/" + year + " ";
            //int storeEndDate = DateTime.DaysInMonth(year, month);
            //DateTime datetime = DateTime.ParseExact(nowdate, "d/M/yyyy", CultureInfo.InvariantCulture);
            //endDate = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            startDateOnDGV = DateTime.ParseExact(strStartDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            endDateOnDGV = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            myReservationList = reservationDataService.FilterReservationByDgvDate(startDateOnDGV, endDateOnDGV);
            
            // public virtual void createButton(int centerPointFirstCell, int y1, int totalWidth, int reserveId, int roomId)

            // remeber that this foreach is guarnteed filter
            // meaning all reservation date ranges are valid for this month
            foreach(var item in myReservationList)
            {


                //if date of reservation occurs inclusively in datagridview
                if (item.StartDate >= startDateOnDGV &&  item.EndDate <= endDateOnDGV)
                {
                    //string myRoomName = roomInfo.RoomNumber;
                    //public void findFirstcell(DateTime startDate, DateTime endDate, long reserveId, RoomInfo selectedRoom)
                   findFirstcell(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                }

                // there is backflow from previous dates
                // aka if a reservation ends on this month but starts in a previous month
                else if(item.StartDate <= startDateOnDGV && item.EndDate <= endDateOnDGV)
                {
                    FindFirstButtBackFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                }

                // if there is overflow on next dates
                // aka if reservation starts on the month now but ends on a later month
                
                else if ((item.StartDate <= endDateOnDGV && item.StartDate >= startDateOnDGV) && item.EndDate >= endDateOnDGV)
                {
                    FindFirstButtFrontFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                    MessageBox.Show(item.ResId.ToString()+"i am working with");
                }
                
                // if there is overflow on both ends
                //
                /*
                else if (item.StartDate <= endDateOnDGV && item.EndDate >= endDateOnDGV)
                {
                    FindFirstButtBackFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                }
                */
                
            }
        }
        
    } 


}

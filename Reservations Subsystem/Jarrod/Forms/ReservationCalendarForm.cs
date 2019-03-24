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
        //public event EventHandler OnShowReservationInfo;
        public ReservationCalendarForm()
        {

            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");


        }
        public DateTime TestDate
        {
            get { return dtpTest.Value; }
            set { dtpTest.Value = value; }

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

            string query = "SELECT roomNumber, roomType  FROM room";
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
                        calendar.Rows[i].Cells[newColumnIndex].Value = dgvhello.Rows[i].Field<string>(0).ToString() +" "+"("+dgvhello.Rows[i].Field<string>(1).ToString()+")";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
            dtpTest.CustomFormat = "dd MMMM yyyy dddd";
            //dtpEndDate.CustomFormat = "dd MMMM yyyy dddd";
            TestDate = DateTime.Today.AddDays(1);
            RoomDataService roomData = new RoomDataService();
            //roomData.getAllRoomId();
            //MessageBox.Show(DateTime.Now.ToString("MMMM"));
            //MessageBox.Show(DateTime.Now.Year.ToString());
            //int month = Array.IndexOf(monthString, DateTime.Now.ToString("MMMM")) + 1, year = Int32.Parse(DateTime.Now.ToString("yyyy"));
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);

            calendar.ClearSelection();
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            dtpTest.CustomFormat = "dd-MM-yyyy";
            displayReservationButt(month, year);
            //DeleteAllButtons();
        }

        private void calendar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {

            int monthprev = Array.IndexOf(monthString, btnPrevMonth.Text);
            int monthNow = Array.IndexOf(monthString, btnMainYear.Text);

 
            if (monthprev == 0) //from feb to janurary
            {
                btnNextMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnPrevMonth.Text;
                btnPrevMonth.Text = monthString[11];

                //btnMainYear.Text = btnMainYear.Text;

            }
            else if(monthprev == 11)
            {

                btnNextMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnPrevMonth.Text;
                btnPrevMonth.Text = monthString[monthprev - 1];

                //btnMainYear.Text = btnMainYear.Text;
                btnMainYear.Text = (Int32.Parse(btnMainYear.Text) - 1).ToString();
                btnNextYear.Text = (Int32.Parse(btnNextYear.Text) - 1).ToString();
                btnPrevYear.Text = (Int32.Parse(btnPrevYear.Text) - 1).ToString();
            }
            else
            {
                btnNextMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnPrevMonth.Text;
                btnPrevMonth.Text = monthString[monthprev - 1];
                //decrementYear = 1;
            }
            /*
            DeleteAllButtons();

            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            displayReservationButt(month, year);
            */
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {

            int monthnext = Array.IndexOf(monthString, btnNextMonth.Text);
            if (monthnext == 0)//December
            {
                btnPrevMonth.Text = btnMainMonth.Text;
                btnMainMonth.Text = btnNextMonth.Text;
                btnNextMonth.Text = monthString[monthnext + 1];


                btnMainYear.Text = (Int32.Parse(btnMainYear.Text) + 1).ToString();
                btnNextYear.Text = (Int32.Parse(btnNextYear.Text) + 1).ToString();
                btnPrevYear.Text = (Int32.Parse(btnPrevYear.Text) + 1).ToString();



            }
            else if (monthnext == 11)//December
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
            DeleteAllButtons();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            displayReservationButt(month, year);
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
            DeleteAllButtons();
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            displayReservationButt(month, year);


        }

        private void btnNextYear_Click(object sender, EventArgs e)
        {
            btnMainYear.Text = (Int32.Parse(btnMainYear.Text) + 1).ToString();
            btnNextYear.Text = (Int32.Parse(btnNextYear.Text) + 1).ToString();
            btnPrevYear.Text = (Int32.Parse(btnPrevYear.Text) + 1).ToString();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            DeleteAllButtons();
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            displayReservationButt(month, year);

            /*
            DeleteAllButtons();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            displayReservationButt(month, year);
            */

        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {


        }
        private void ShowAddReservationForm()
        {
            AddReservationView frm2 = new AddReservationView();
            frm2.referencefrm1 = this;
            MessageBox.Show("jk;ljkl;");
            frm2.Show();

        }
        //2/13/2019 10:39 AM
        /*
        string iDate = "05/05/2005";
        DateTime oDate = Convert.ToDateTime(iDate);

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
            /*
            if (Selected)
            {
                MessageBox.Show("this selection is not allowed");
                calendar.ClearSelection();
            }
            */

            // If amount of rows selected is only equal to 1 
            // handles both left to right and right to left selection
            if (rowIndexes.Max() - rowIndexes.Min() == 0)
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
                //string phrase = row.Cells[0].Value.ToString();
                //string[] words = phrase.Split(' ');
                string[] words = calendar.Rows[rowIndexes.Min()].Cells["rooms"].Value.ToString().Split(' ');
                frm.RoomNumber = words[0];
                //frm.StartDate = DateFormat(firstDateReservation);
                //frm.EndDate = DateFormat(lastDateReservation);
                frm.SetValuesOnSelection(DateFormat(firstDateReservation), DateFormat(lastDateReservation));
                int startDay = DateFormat(firstDateReservation).Day;
                int endDay = DateFormat(lastDateReservation).Day;
  
                int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
                frm.DgvYear = year;
                frm.DgvMonth = month;
                RoomDataService roomDateService = new RoomDataService();
                RoomInfo myRoomInfo = new RoomInfo();
                myRoomInfo = roomDateService.getRoomInfoByRoomNumber(frm.RoomNumber);
                int roomId = Convert.ToInt32(myRoomInfo.RoomId);

                int reservationIntefere = ReservationCheck(Convert.ToInt32(startDay), Convert.ToInt32(endDay), month, year, roomId);

                //int resStart = ReservationCheck(Convert.ToInt32(startDay), Convert.ToInt32(endDay), month, year, roomId);
                if (reservationIntefere >= 1)
                {
                    MessageBox.Show("Selection is not allowed here reservation have confliciting dates"); 
                }
                else
                {
                    try
                    {

                        RoomDataService why = new RoomDataService();
                        //Boolean edit = false;
                        //editing is false
                        frm.viewMonth = month;
                        frm.viewYear = year;
                        ReservationDataPresenter data = new ReservationDataPresenter(frm, why);
                        data.Show();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
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
                Int32 selectedCellCount = calendar.GetCellCount(DataGridViewElementStates.Selected);
                if (calendar.Columns[0].Selected)
                {
                    MessageBox.Show("Selection here is not allowed");
                    calendar.ClearSelection();
                }
                else if (selectedCellCount == 1)
                {
                    MessageBox.Show("Selection here need to be more than 1 cell");
                    calendar.ClearSelection();
                    
                }
                else if (selectedCellCount > 0)
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
                    List<int> distinctRowIndexes = rowIndexes.Distinct().ToList();
                    List<int> distinctColumnIndexes = columnIndexes.Distinct().ToList();
                    SelectionOnDgvCalendar(distinctRowIndexes, distinctColumnIndexes);
                }

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
         
                roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));
               
                string searchValueRow = roomInfo.RoomNumber;
    
                string searchValueColumn = startDate.Day.ToString();
                int rowIndex = -1;
                //int columnIndex = -1;

                //getting row index for y
                foreach (DataGridViewRow row in calendar.Rows)
                {
                    string phrase = row.Cells[0].Value.ToString();
                    string[] words = phrase.Split(' ');
                    if (words[0].Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                    /*
                    if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                    */


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
                //MessageBox.Show(stayInDays.Days +"reserveId is"+ reserveId.ToString());
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

            string searchValueColumn = startDate.Day.ToString();
            int rowIndex = -1;
            //int columnIndex = -1;

            //getting row index for y
            foreach (DataGridViewRow row in calendar.Rows)
            {
                string phrase = row.Cells[0].Value.ToString();
                string[] words = phrase.Split(' ');
                if (words[0].Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
                /*
                if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
                */


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
            int totalWidth = (daysAtEnd * 40)-20;
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
                roomInfo = roomDataService.getRoomInfoById(Convert.ToInt32(roomId));
                string searchValueRow = roomInfo.RoomNumber;

                string searchValueColumn = startDate.Day.ToString();
                int rowIndex = -1;
                //int columnIndex = -1;

                //getting row index for y
                foreach (DataGridViewRow row in calendar.Rows)
                {
                    string phrase = row.Cells[0].Value.ToString();
                    string[] words = phrase.Split(' ');
                    if (words[0].Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                    /*
                    if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                    */


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
                int stayInDays = startDate.Day;

                int me = DateTime.DaysInMonth(startDate.Year, startDate.Month);
                int totalWidth = ((me-startDate.Day+1)*40)-20 ;
                string name = Convert.ToString(reserveId);


                createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DoubleOverFlow(DateTime startDate, DateTime endDate, long reserveId, string roomId, DateTime LastDayInMonth)
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
            string searchValueColumn = startDate.Day.ToString();
            int rowIndex = -1;
            //int columnIndex = -1;

            //getting row index for y
            foreach (DataGridViewRow row in calendar.Rows)
            {
                string phrase = row.Cells[0].Value.ToString();
                string[] words = phrase.Split(' ');
                if (words[0].Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
                /*
                if (row.Cells[0].Value.ToString().Equals(searchValueRow))
                {
                    rowIndex = row.Index;
                    break;
                }
                */


            }
            // need to find location first datagridview cell that reservation occurs in
            /*
            int columnIndex = DateTime.DaysInMonth(LastDayInMonth.Year, LastDayInMonth.Month);
            MessageBox.Show(columnIndex.ToString());
            */
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

            

            int totalWidth = 31 * 40;
            string name = Convert.ToString(reserveId);


            createButton(centerPointFirstCell, y1, totalWidth, Convert.ToInt32(reserveId), Convert.ToInt32(roomInfo.RoomId));

        }


        public virtual void createButton(int centerPointFirstCell, int y1, int totalWidth, int reserveId, int roomId)
        {
            //INfo for button gathered from database
            ReservationInfo myResInfo = new ReservationInfo();
            CustomerInfo myCustomerInfo = new CustomerInfo();

            ReservationDataService reservationDataService = new ReservationDataService();
            RoomDataService roomDataService = new RoomDataService();
            CustomerDataService customerDataService = new CustomerDataService();

            myResInfo = reservationDataService.GetReservationInfoById(reserveId);
            int myCustomerId = myResInfo.CustomerId;
            myCustomerInfo = customerDataService.GetCustomerInfoById(myCustomerId);
            ReservationDataService resData = new ReservationDataService();
            CustomerDataService custData = new CustomerDataService();


            //ReservationInfo resInfo = resData.GetReservationInfoById(reserveId);
            ToolTip tip = new ToolTip();
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
           

            dynamicButton.Text = myCustomerInfo.Name;
            dynamicButton.Name = reserveId.ToString();
            dynamicButton.roomId = roomId;
            //dynamicButton.Font = new Font("Georgia", 16);
            tip.ShowAlways = true;
            tip.SetToolTip(dynamicButton, ToolTipInfo(reserveId, roomId));
            
            dynamicButton.Click += new EventHandler(myButtonHandler_SingleClick);
            
            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();





        }
        public string ToolTipInfo(int reserveId, int roomId)
        {
            ReservationInfo myResInfo = new ReservationInfo();
            RoomInfo myRoomInfo = new RoomInfo();
            CustomerInfo myCustomerInfo = new CustomerInfo();
            ReservationDataService reservationDataService = new ReservationDataService();
            RoomDataService roomDataService = new RoomDataService();
            CustomerDataService customerDataService = new CustomerDataService();

            string myString ="";
            myResInfo = reservationDataService.GetReservationInfoById(Convert.ToInt32(reserveId));
            int myRoomId = Convert.ToInt32(myResInfo.RoomId);
            myRoomInfo = roomDataService.getRoomInfoById(myRoomId);
            int myCustomerId = myResInfo.CustomerId;
            myCustomerInfo = customerDataService.GetCustomerInfoById(myCustomerId);


            string myStartDate = myResInfo.StartDate.ToString();
            string myEndDate = myResInfo.EndDate.ToString();
            //string lengthOfStay = myResInfo.LenghtOfStay.ToString();
            int lenghtOfStay = (myResInfo.EndDate - myResInfo.StartDate).Days;
            string totalAmt = myResInfo.TotalPrice.ToString();
            string rate = myResInfo.RoomRate.ToString();
            string custName = myCustomerInfo.Name;

            myString = " \t \t Reservation Info"+System.Environment.NewLine+
                "StartDate" +" \t\t "+"EndDate"+System.Environment.NewLine+
                myStartDate + " \t " + myEndDate +"\t"+lenghtOfStay.ToString()+" day(s)"+System.Environment.NewLine+
                System.Environment.NewLine +
                "Total Amount " +totalAmt+ " \t "+rate+ "/per Days"+System.Environment.NewLine+
                System.Environment.NewLine +
                "Customer Name" +System.Environment.NewLine+
                 custName;
            return myString;
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
                    myCustomerInfo = customerDataService.GetCustomerInfoById(myCustomerId);
                    int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
                    MessageBox.Show(myResInfo.ResId.ToString() + "over here");

                    theFrmView.viewYear = year;
                    theFrmView.viewMonth = month;
                    theFrmView.DgvYear = year;
                    theFrmView.DgvMonth = month;
                    ReservationDataPresenter data = new ReservationDataPresenter(theFrmView, myResInfo, myRoomInfo, myCustomerInfo, myButton);
                    data.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
              

            }
        }
        
        public void DeleteAllButtons()
        {
            List<MyButton> buttonIds = new List<MyButton>();
            foreach (var button in this.Controls.OfType<MyButton>().ToList())
            {
                Controls.Remove(button);
               button.Dispose();
            }
        }
        public void DeleteButtonById(int Id)
        {
            List<MyButton> buttonIds = new List<MyButton>();
            foreach (var button in this.Controls.OfType<MyButton>())
            {
                if(button.Name.Equals(Id.ToString()))
                {
                    Controls.Remove(button);
                    MessageBox.Show("deleted ahppenedf");
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
            frm2.ShowDialog();
            //this.Hide();
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
            DateTime firstSelectedDateOnDgv, lastSelectedDateOnDgv;
            string strStartDate, strEndDate;

            //formating string for conversions to DateTime
            string paddingTime = "00:00:00";

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

        public int ReservationCheckAdvanced(int startDay, int startMonth, int startYear, int endDay, int endMonth, int endYear, int roomId)
        {

            // classes initialized
            List<ReservationInfo> myReservationList = new List<ReservationInfo>();
            List<DateTime> myDates = new List<DateTime>();
            RoomDataService roomDataService = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();
            ReservationDataService reservationDataService = new ReservationDataService();

            // initalize fields
            //int storeEndDate = DateTime.DaysInMonth(year, month);
            DateTime firstSelectedDateOnDgv, lastSelectedDateOnDgv;
            string strStartDate, strEndDate;

            //formating string for conversions to DateTime
            string paddingTime = "00:00:00";

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
            }else{
                strEndDay = endDay.ToString();
            }
           
            if (startMonth < 10)
            {
                strStartDate = startYear + "-0" + startMonth + "-" + strStartDay + " " + paddingTime;
                //strEndDate = year + "-0" + month + "-" + strEndDay + " " + paddingTime;
            }else
            {
                strStartDate = startYear + "-" + startMonth + "-" + strStartDay + " " + paddingTime;
                //strEndDate = year + "-" + month + "-" + strEndDay + " " + paddingTime;
            }
            if (endMonth < 10)
            {
                strEndDate = endYear + "-0" + endMonth + "-" + strEndDay + " " + paddingTime;
            }
            else
            {
                strEndDate = endYear + "-" + endMonth + "-" + strStartDay + " " + paddingTime;
                //strEndDate = year + "-" + month + "-" + strEndDay + " " + paddingTime;
            }

            // string strStartDate = "01/" + month + "/" + year + " ";
            // string strEndDate = "31/" + month + "/" + year + " ";
            //int storeEndDate = DateTime.DaysInMonth(year, month);
            //DateTime datetime = DateTime.ParseExact(nowdate, "d/M/yyyy", CultureInfo.InvariantCulture);
            //endDate = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
            firstSelectedDateOnDgv = DateTime.ParseExact(strStartDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            lastSelectedDateOnDgv = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            
            myReservationList = reservationDataService.FilterReservationByDgvDate(firstSelectedDateOnDgv, lastSelectedDateOnDgv, roomId);
            //MessageBox.Show(myReservationList.Count.ToString());
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
            string paddingTime = "00:00:00";

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
            myReservationList = reservationDataService.ShowAllRes(startDateOnDGV, endDateOnDGV);
            
            // public virtual void createButton(int centerPointFirstCell, int y1, int totalWidth, int reserveId, int roomId)

            // remeber that this foreach is guarnteed filter
            // meaning all reservation date ranges are valid for this month
            foreach(var item in myReservationList)
            {
                

                //if date of reservation occurs inclusively in datagridview
                if (item.StartDate.Date >= startDateOnDGV.Date &&  item.EndDate.Date <= endDateOnDGV.Date)
                {
                    //string myRoomName = roomInfo.RoomNumber;
                    //public void findFirstcell(DateTime startDate, DateTime endDate, long reserveId, RoomInfo selectedRoom)
                    findFirstcell(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                }

                // there is backflow from previous dates
                // aka if a reservation ends on this month but starts in a previous month
                else if(item.StartDate.Date <= startDateOnDGV.Date && item.EndDate.Date <= endDateOnDGV.Date)
                {
                    FindFirstButtBackFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId);

                }

                // if there is overflow on next dates
                // aka if reservation starts on the month now but ends on a later month

                else if ((item.StartDate.Date <= endDateOnDGV.Date && item.StartDate.Date >= startDateOnDGV.Date) && item.EndDate.Date >= endDateOnDGV.Date)
                {
                    FindFirstButtFrontFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId);
                }
                
                // if there is overflow on both ends
                //
                
                else if (item.StartDate.Date <= endDateOnDGV.Date && item.EndDate.Date >= endDateOnDGV.Date)
                {
                    DoubleOverFlow(item.StartDate, item.EndDate, item.ResId, item.RoomId, endDateOnDGV);
                }
                else
                {
                    MessageBox.Show("an error has occured");
                }
                
                
            }
        }
  
        private void btnCreateReservation_Click(object sender, EventArgs e)
        {

            AddReservationView frm = new AddReservationView();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);

            frm.referencefrm1 = this;
            frm.DgvYear = year;
            frm.DgvMonth = month;
            ReservationDataPresenter data = new ReservationDataPresenter(frm);
            data.Show();
        }
        public List<DateTime> GetDatesOnDgv()
        {
            List<DateTime> dateTimes = new List<DateTime>();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);

            DateTime startDateOnDgv, endDateOnDgv;
            int storeEndDate = DateTime.DaysInMonth(year, month);
            string strStartDate, strEndDate;
            string paddingTime = "00:00:00";

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
            startDateOnDgv = DateTime.ParseExact(strStartDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            endDateOnDgv = DateTime.ParseExact(strEndDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            dateTimes.Add(startDateOnDgv);
            dateTimes.Add(endDateOnDgv);
            return dateTimes;
            //myReservationList = reservationDataService.FilterReservationByDgvDate(startDateOnDGV, endDateOnDGV);

        }
        private void btnViewReservation_Click(object sender, EventArgs e)
        {
          /*            MSR frm = new MSR();
            ReservationDataService resData = new ReservationDataService();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);

            List<DateTime> dgvDateList = GetDatesOnDgv();
            frm.LoadMrsDgv(dgvDateList[0], dgvDateList[1]);
            //List<ReservationInfo> listOfReservation = resData.MsrReservation(dgvDateList[0], dgvDateList[1]);

            frm.referencefrm1 = this;

            frm.Show();
            */
        }

        private void btnOccRep_Click(object sender, EventArgs e)
        {
            /*
            FrmOccupancy frm = new FrmOccupancy();
            ReservationDataService resData = new ReservationDataService();
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);

            List<DateTime> dgvDateList = GetDatesOnDgv();
            frm.LoadOccupancyRep(dgvDateList[0], dgvDateList[1]);
            //List<ReservationInfo> listOfReservation = resData.MsrReservation(dgvDateList[0], dgvDateList[1]);

            frm.referencefrm1 = this;

            frm.Show();
            */
        }
    } 


}

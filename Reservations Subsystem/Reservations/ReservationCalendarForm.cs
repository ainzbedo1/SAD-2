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

namespace Reservations_Subsystem
{
    public partial class ReservationCalendarForm : Form
    {
        //public ViewRoom referenceViewRoom { get; set; }
        // DataGridView dgvDbRoom = new DataGridView();
        //public AddReservation AddReservationForm { get; set; }
        public MySqlConnection conn;
        public AddReservation reference { get; set; }
        public string[] monthString = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public int buttonCreateCounter = 0;
        public ReservationCalendarForm()
        {

            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");


        }

        #region
        public void displayCalendar(int month, int year)
        {
           
            string nowdate = "01/" + month + "/" + year;
            DateTime datetime = DateTime.ParseExact(nowdate, "d/M/yyyy", CultureInfo.InvariantCulture);

            DataRow dr;
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
        }
        #endregion //display calendar

        private void Form1_Load(object sender, EventArgs e)
        {
            int month = Array.IndexOf(monthString, btnMainMonth.Text) + 1, year = Int32.Parse(btnMainYear.Text);
            displayCalendar(month, year);
            calendar.ClearSelection();
            this.button2.Click += new EventHandler(myButtonHandler_Click);
            int colCount = this.calendar.ColumnCount;
            this.Size = new Size(colCount * 40 + 80, 652);
            calendar.Size = new Size(colCount * 40 + 65, 652);
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
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
            AddReservation frm2 = new AddReservation();
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
                MessageBox.Show(finalDateFormat);
                DateTime dateTimeConvert = Convert.ToDateTime(finalDateFormat);
                return dateTimeConvert;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return DateTime.Now;
            }
        }
        
          
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
                createButton(centerPointFirstCell, y1, totalWidth, 20);
                
                //get column headers of first cell and last cell of selection
                string firstDate = calendar.Columns[lastColumnIndex].HeaderText;
                string lastDate = calendar.Columns[firstColumnIndex].HeaderText;

                //Setting up frm2 values 
                AddReservation frm2 = new AddReservation();
                frm2.referencefrm1 = this;
                DataTable dgvRoomInfo = new DataTable();
                string roomNumber = calendar.Rows[rowIndexes.Min()].Cells["rooms"].Value.ToString();
                MessageBox.Show(roomNumber);
                string query = "SELECT roomNumber, roomType, description, occupied FROM room WHERE roomNumber = '" + roomNumber + "' ";
                using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
                {

                    blah.Fill(dgvRoomInfo);


                }
                MessageBox.Show(dgvRoomInfo.Rows.Count.ToString());
                frm2.StartDate = DateFormat(firstDate);
                frm2.EndDate  = DateFormat(lastDate);
                frm2.RoomNumber = dgvRoomInfo.Rows[0]["roomNumber"].ToString();
                frm2.RoomType = dgvRoomInfo.Rows[0]["roomType"].ToString();
                frm2.Show();





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
                    createButton(centerPointFirstCell, y1, totalWidth, 20);
                    /*                 
                    MessageBox.Show(y1.ToString());

                    MessageBox.Show("Button Created"+ i.ToString());
                    MessageBox.Show(y1.ToString());
                    */
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

                        int biggestColumn = 0;
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
        /*
        protected virtual void createButton(int x, int y)
        {
            buttonCreateCounter++;
            Button new_Button = new Button();
            Button dynamicButton = new Button();
            dynamicButton.Location = new Point(x, y);
            dynamicButton.Height = 10;
            dynamicButton.Width = 1;
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Text = "I am button number" + buttonCreateCounter.ToString();
            dynamicButton.Name = "DynamicButton" + buttonCreateCounter.ToString();
            dynamicButton.Font = new Font("Georgia", 16);
            new_Button.Click += new EventHandler(myButtonHandler_Click);

            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();
        }
        */

        //creates button on specified location can pass button specifiction here
        protected virtual void createButton(int middleLocationX, int middleLocationY, int width, int height)
        {
            buttonCreateCounter++;
            //Button new_Button = new Button();
            Button dynamicButton = new Button();
            //dynamicButton.Location = new Point(1, 1);
            //dynamicButton.Location = new Point(545, 470);
            dynamicButton.Location = new Point(middleLocationX, middleLocationY);
            dynamicButton.Height = height;
            dynamicButton.Width = width;
            dynamicButton.BackColor = Color.Red;
            dynamicButton.ForeColor = Color.Blue;

            dynamicButton.Text = "dfasfa";
            dynamicButton.Name = "sdfadfs";
            dynamicButton.Font = new Font("Georgia", 16);
            dynamicButton.Click += new EventHandler(myButtonHandler_Click);

            Controls.Add(dynamicButton);
            dynamicButton.BringToFront();
            // MessageBox.Show(dynamicButton.Name.ToString());
        }

        //this method gives the new buttons functionality
        public void myButtonHandler_Click(Object sender, EventArgs e)
        {
            //'VERIFYING THE BUTTONS
            if (sender is Button)
            {
                createButton(40, 40, 40, 40);
                //createButton();//'CREATE A NEW BUTTON
                /*
                AddReservation frm = new AddReservation();
                frm.Show();
                */

                MessageBox.Show("button functionality created");
            }
        }

        private void calendar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            #region
            /*
             DataGridView name = new DataGridView();
             name.Location = this.calendar.PointToScreen(
                 calendar.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
             MessageBox.Show(name.Location.ToString());
             createButton(name.Location);
             */
             
            #endregion 
            /*
            int x, y;
            x = this.calendar.GetCellDisplayRectangle(e.ColumnIndex,
            e.RowIndex, false).Left + calendar.Left;
            y = this.calendar.GetCellDisplayRectangle(e.ColumnIndex,
            e.RowIndex, false).Bottom + calendar.Top;
            createButton(x, y);
          
            int a, b;
            a = this.calendar.GetCellDisplayRectangle(e.ColumnIndex,
            e.RowIndex, false).Right + calendar.Left;
            b = this.calendar.GetCellDisplayRectangle(e.ColumnIndex,
            e.RowIndex, false).Bottom + calendar.Top;
            createButton(a, b);
            */
            

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
                MessageBox.Show("hih");

            }
            MessageBox.Show("hih");
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
    }

}

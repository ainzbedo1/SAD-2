namespace Reservations_Subsystem
{
    partial class ReservationCalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar = new System.Windows.Forms.DataGridView();
            this.btnMainMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevYear = new System.Windows.Forms.Button();
            this.btnMainYear = new System.Windows.Forms.Button();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnOccRep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.AllowUserToAddRows = false;
            this.calendar.AllowUserToResizeColumns = false;
            this.calendar.AllowUserToResizeRows = false;
            this.calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendar.Location = new System.Drawing.Point(-3, 189);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(1200, 652);
            this.calendar.TabIndex = 0;
            this.calendar.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.calendar_CellBeginEdit);
            this.calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellClick);
            this.calendar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellContentClick);
            this.calendar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.calendar_CellEnter);
            this.calendar.SelectionChanged += new System.EventHandler(this.calendar_SelectionChanged);
            this.calendar.DragOver += new System.Windows.Forms.DragEventHandler(this.calendar_DragOver);
            this.calendar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calendar_KeyDown);
            // 
            // btnMainMonth
            // 
            this.btnMainMonth.Location = new System.Drawing.Point(289, 63);
            this.btnMainMonth.Name = "btnMainMonth";
            this.btnMainMonth.Size = new System.Drawing.Size(132, 36);
            this.btnMainMonth.TabIndex = 1;
            this.btnMainMonth.Text = "January";
            this.btnMainMonth.UseVisualStyleBackColor = true;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.Location = new System.Drawing.Point(289, 12);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(132, 36);
            this.btnPrevMonth.TabIndex = 2;
            this.btnPrevMonth.Text = "December";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(289, 116);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(132, 36);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = "February";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPrevYear
            // 
            this.btnPrevYear.Location = new System.Drawing.Point(509, 11);
            this.btnPrevYear.Name = "btnPrevYear";
            this.btnPrevYear.Size = new System.Drawing.Size(132, 36);
            this.btnPrevYear.TabIndex = 4;
            this.btnPrevYear.Text = "2018";
            this.btnPrevYear.UseVisualStyleBackColor = true;
            this.btnPrevYear.Click += new System.EventHandler(this.btnPrevYear_Click);
            // 
            // btnMainYear
            // 
            this.btnMainYear.Location = new System.Drawing.Point(509, 63);
            this.btnMainYear.Name = "btnMainYear";
            this.btnMainYear.Size = new System.Drawing.Size(132, 36);
            this.btnMainYear.TabIndex = 5;
            this.btnMainYear.Text = "2019";
            this.btnMainYear.UseVisualStyleBackColor = true;
            this.btnMainYear.Click += new System.EventHandler(this.mainYearBTN_Click);
            // 
            // btnNextYear
            // 
            this.btnNextYear.Location = new System.Drawing.Point(509, 116);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(132, 36);
            this.btnNextYear.TabIndex = 6;
            this.btnNextYear.Text = "2020";
            this.btnNextYear.UseVisualStyleBackColor = true;
            this.btnNextYear.Click += new System.EventHandler(this.btnNextYear_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(705, 86);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(123, 23);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(705, 134);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(123, 23);
            this.btnViewCustomers.TabIndex = 11;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // dtpTest
            // 
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTest.Location = new System.Drawing.Point(59, 27);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(200, 20);
            this.dtpTest.TabIndex = 15;
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(522, 162);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(119, 23);
            this.btnCreateReservation.TabIndex = 16;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Cursor = System.Windows.Forms.Cursors.No;
            this.btnViewReservation.Location = new System.Drawing.Point(6, 19);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(119, 23);
            this.btnViewReservation.TabIndex = 18;
            this.btnViewReservation.Text = "View MSR";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnOccRep
            // 
            this.btnOccRep.Location = new System.Drawing.Point(159, 19);
            this.btnOccRep.Name = "btnOccRep";
            this.btnOccRep.Size = new System.Drawing.Size(119, 23);
            this.btnOccRep.TabIndex = 18;
            this.btnOccRep.Text = "Occupancy Report";
            this.btnOccRep.UseVisualStyleBackColor = true;
            this.btnOccRep.Click += new System.EventHandler(this.btnOccRep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewReservation);
            this.groupBox1.Controls.Add(this.btnOccRep);
            this.groupBox1.Location = new System.Drawing.Point(699, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 53);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // ReservationCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 866);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.dtpTest);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnNextYear);
            this.Controls.Add(this.btnMainYear);
            this.Controls.Add(this.btnPrevYear);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.btnMainMonth);
            this.Controls.Add(this.calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReservationCalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calendar;
        private System.Windows.Forms.Button btnMainMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevYear;
        private System.Windows.Forms.Button btnMainYear;
        private System.Windows.Forms.Button btnNextYear;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnOccRep;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


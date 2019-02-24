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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.txtFirstDate = new System.Windows.Forms.TextBox();
            this.txtLastDate = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
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
            this.btnPrevYear.Location = new System.Drawing.Point(509, 12);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(956, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(956, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Create button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(1238, 25);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(123, 23);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(739, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(1238, 63);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(123, 23);
            this.btnViewCustomers.TabIndex = 11;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // txtFirstDate
            // 
            this.txtFirstDate.Location = new System.Drawing.Point(48, 100);
            this.txtFirstDate.Name = "txtFirstDate";
            this.txtFirstDate.Size = new System.Drawing.Size(100, 20);
            this.txtFirstDate.TabIndex = 12;
            // 
            // txtLastDate
            // 
            this.txtLastDate.Location = new System.Drawing.Point(48, 152);
            this.txtLastDate.Name = "txtLastDate";
            this.txtLastDate.Size = new System.Drawing.Size(100, 20);
            this.txtLastDate.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(317, 162);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(739, 160);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(119, 23);
            this.btnCreateReservation.TabIndex = 16;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(956, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Invi Dgv";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ReservationCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 866);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.txtLastDate);
            this.Controls.Add(this.txtFirstDate);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView calendar;
        private System.Windows.Forms.Button btnMainMonth;
        private System.Windows.Forms.Button btnPrevMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPrevYear;
        private System.Windows.Forms.Button btnMainYear;
        private System.Windows.Forms.Button btnNextYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.TextBox txtFirstDate;
        private System.Windows.Forms.TextBox txtLastDate;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button button3;
    }
}


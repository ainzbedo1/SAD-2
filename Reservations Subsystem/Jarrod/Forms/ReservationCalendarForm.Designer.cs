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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calendar = new System.Windows.Forms.DataGridView();
            this.btnMainMonth = new System.Windows.Forms.Button();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPrevYear = new System.Windows.Forms.Button();
            this.btnMainYear = new System.Windows.Forms.Button();
            this.btnNextYear = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnOccRep = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.AllowUserToAddRows = false;
            this.calendar.AllowUserToResizeColumns = false;
            this.calendar.AllowUserToResizeRows = false;
            this.calendar.BackgroundColor = System.Drawing.Color.White;
            this.calendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calendar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.calendar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calendar.DefaultCellStyle = dataGridViewCellStyle2;
            this.calendar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.calendar.Location = new System.Drawing.Point(12, 282);
            this.calendar.Name = "calendar";
            this.calendar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnMainMonth.FlatAppearance.BorderSize = 0;
            this.btnMainMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnMainMonth.Location = new System.Drawing.Point(457, 55);
            this.btnMainMonth.Name = "btnMainMonth";
            this.btnMainMonth.Size = new System.Drawing.Size(136, 36);
            this.btnMainMonth.TabIndex = 1;
            this.btnMainMonth.Text = "January";
            this.btnMainMonth.UseVisualStyleBackColor = true;
            this.btnMainMonth.Click += new System.EventHandler(this.btnMainMonth_Click);
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.FlatAppearance.BorderSize = 0;
            this.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevMonth.Location = new System.Drawing.Point(457, 8);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(136, 36);
            this.btnPrevMonth.TabIndex = 2;
            this.btnPrevMonth.Text = "December";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.FlatAppearance.BorderSize = 0;
            this.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNextMonth.Location = new System.Drawing.Point(457, 104);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(136, 36);
            this.btnNextMonth.TabIndex = 3;
            this.btnNextMonth.Text = "February";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPrevYear
            // 
            this.btnPrevYear.FlatAppearance.BorderSize = 0;
            this.btnPrevYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevYear.Location = new System.Drawing.Point(621, 8);
            this.btnPrevYear.Name = "btnPrevYear";
            this.btnPrevYear.Size = new System.Drawing.Size(136, 36);
            this.btnPrevYear.TabIndex = 4;
            this.btnPrevYear.Text = "2018";
            this.btnPrevYear.UseVisualStyleBackColor = true;
            this.btnPrevYear.Click += new System.EventHandler(this.btnPrevYear_Click);
            // 
            // btnMainYear
            // 
            this.btnMainYear.FlatAppearance.BorderSize = 0;
            this.btnMainYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnMainYear.Location = new System.Drawing.Point(621, 56);
            this.btnMainYear.Name = "btnMainYear";
            this.btnMainYear.Size = new System.Drawing.Size(136, 36);
            this.btnMainYear.TabIndex = 5;
            this.btnMainYear.Text = "2019";
            this.btnMainYear.UseVisualStyleBackColor = true;
            this.btnMainYear.Click += new System.EventHandler(this.mainYearBTN_Click);
            // 
            // btnNextYear
            // 
            this.btnNextYear.FlatAppearance.BorderSize = 0;
            this.btnNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextYear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNextYear.Location = new System.Drawing.Point(621, 105);
            this.btnNextYear.Name = "btnNextYear";
            this.btnNextYear.Size = new System.Drawing.Size(136, 36);
            this.btnNextYear.TabIndex = 6;
            this.btnNextYear.Text = "2020";
            this.btnNextYear.UseVisualStyleBackColor = true;
            this.btnNextYear.Click += new System.EventHandler(this.btnNextYear_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(946, 18);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(123, 35);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomers.Location = new System.Drawing.Point(1075, 18);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(123, 35);
            this.btnViewCustomers.TabIndex = 11;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCreateReservation.FlatAppearance.BorderSize = 0;
            this.btnCreateReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReservation.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.ForeColor = System.Drawing.Color.White;
            this.btnCreateReservation.Location = new System.Drawing.Point(821, 18);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(119, 35);
            this.btnCreateReservation.TabIndex = 16;
            this.btnCreateReservation.Text = "Create Reservation";
            this.btnCreateReservation.UseVisualStyleBackColor = false;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnViewReservation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnViewReservation.FlatAppearance.BorderSize = 0;
            this.btnViewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReservation.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservation.ForeColor = System.Drawing.Color.White;
            this.btnViewReservation.Location = new System.Drawing.Point(116, 18);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(119, 35);
            this.btnViewReservation.TabIndex = 18;
            this.btnViewReservation.Text = "View MSR";
            this.btnViewReservation.UseVisualStyleBackColor = false;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnOccRep
            // 
            this.btnOccRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnOccRep.FlatAppearance.BorderSize = 0;
            this.btnOccRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccRep.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccRep.ForeColor = System.Drawing.Color.White;
            this.btnOccRep.Location = new System.Drawing.Point(241, 18);
            this.btnOccRep.Name = "btnOccRep";
            this.btnOccRep.Size = new System.Drawing.Size(119, 35);
            this.btnOccRep.TabIndex = 18;
            this.btnOccRep.Text = "Occupancy Report";
            this.btnOccRep.UseVisualStyleBackColor = false;
            this.btnOccRep.Click += new System.EventHandler(this.btnOccRep_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 50);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1187, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(15, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1200, 52);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 17F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNextYear);
            this.panel2.Controls.Add(this.btnMainYear);
            this.panel2.Controls.Add(this.btnPrevYear);
            this.panel2.Controls.Add(this.btnNextMonth);
            this.panel2.Controls.Add(this.btnPrevMonth);
            this.panel2.Controls.Add(this.btnMainMonth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 148);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddRoom);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnViewCustomers);
            this.panel3.Controls.Add(this.btnOccRep);
            this.panel3.Controls.Add(this.btnCreateReservation);
            this.panel3.Controls.Add(this.btnViewReservation);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1224, 72);
            this.panel3.TabIndex = 23;
            // 
            // ReservationCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1224, 946);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationCalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationCalendarForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnOccRep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}


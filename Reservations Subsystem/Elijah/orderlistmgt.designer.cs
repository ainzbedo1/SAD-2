namespace Reservations_Subsystem
{
    partial class orderlistmgt
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
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.vendorName = new System.Windows.Forms.TextBox();
            this.quanNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvOrd = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvPOL = new System.Windows.Forms.DataGridView();
            this.dtgvPO = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgvPOLC = new System.Windows.Forms.DataGridView();
            this.dtgvPOC = new System.Windows.Forms.DataGridView();
            this.dataComplete = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgvPOLCL = new System.Windows.Forms.DataGridView();
            this.dtgvPOCL = new System.Windows.Forms.DataGridView();
            this.dataCancel = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPO)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataComplete)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOLCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOCL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd2
            // 
            this.btnAdd2.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd2.ForeColor = System.Drawing.Color.Black;
            this.btnAdd2.Location = new System.Drawing.Point(1023, 372);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(108, 35);
            this.btnAdd2.TabIndex = 14;
            this.btnAdd2.Text = "Create PO";
            this.btnAdd2.UseVisualStyleBackColor = false;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.productTxt);
            this.groupBox1.Controls.Add(this.vendorName);
            this.groupBox1.Controls.Add(this.quanNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvOrd);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAdd2);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.txtSub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblVendor);
            this.groupBox1.Controls.Add(this.lblDate2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1250, 427);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(865, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(947, 324);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(184, 40);
            this.txtTotal.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(58, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Price:";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(141, 157);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(345, 29);
            this.txtprice.TabIndex = 34;
            // 
            // productTxt
            // 
            this.productTxt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTxt.Location = new System.Drawing.Point(141, 110);
            this.productTxt.Margin = new System.Windows.Forms.Padding(4);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(345, 29);
            this.productTxt.TabIndex = 33;
            this.productTxt.TextChanged += new System.EventHandler(this.productTxt_TextChanged);
            // 
            // vendorName
            // 
            this.vendorName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorName.Location = new System.Drawing.Point(141, 67);
            this.vendorName.Margin = new System.Windows.Forms.Padding(4);
            this.vendorName.Name = "vendorName";
            this.vendorName.Size = new System.Drawing.Size(345, 29);
            this.vendorName.TabIndex = 32;
            this.vendorName.TextChanged += new System.EventHandler(this.vendorName_TextChanged);
            // 
            // quanNum
            // 
            this.quanNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanNum.Location = new System.Drawing.Point(141, 200);
            this.quanNum.Name = "quanNum";
            this.quanNum.Size = new System.Drawing.Size(120, 38);
            this.quanNum.TabIndex = 29;
            this.quanNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Subtotal:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(320, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(661, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order List";
            // 
            // dtgvOrd
            // 
            this.dtgvOrd.AllowUserToAddRows = false;
            this.dtgvOrd.AllowUserToDeleteRows = false;
            this.dtgvOrd.AllowUserToResizeColumns = false;
            this.dtgvOrd.AllowUserToResizeRows = false;
            this.dtgvOrd.BackgroundColor = System.Drawing.Color.White;
            this.dtgvOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvOrd.Location = new System.Drawing.Point(666, 75);
            this.dtgvOrd.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvOrd.Name = "dtgvOrd";
            this.dtgvOrd.ReadOnly = true;
            this.dtgvOrd.RowHeadersVisible = false;
            this.dtgvOrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvOrd.Size = new System.Drawing.Size(465, 241);
            this.dtgvOrd.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(198, 308);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 44);
            this.button3.TabIndex = 25;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "";
            this.date.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(777, 9);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(345, 29);
            this.date.TabIndex = 22;
            this.date.Value = new System.DateTime(2018, 9, 22, 0, 0, 0, 0);
            // 
            // txtSub
            // 
            this.txtSub.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.Location = new System.Drawing.Point(141, 254);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(344, 29);
            this.txtSub.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(26, 205);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 29);
            this.lblQuantity.TabIndex = 18;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.ForeColor = System.Drawing.Color.Black;
            this.lblVendor.Location = new System.Drawing.Point(37, 67);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(97, 29);
            this.lblVendor.TabIndex = 17;
            this.lblVendor.Text = "Vendor:";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.ForeColor = System.Drawing.Color.Black;
            this.lblDate2.Location = new System.Drawing.Point(661, 9);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(69, 29);
            this.lblDate2.TabIndex = 16;
            this.lblDate2.Text = "Date:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 461);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 452);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cancelBtn);
            this.tabPage2.Controls.Add(this.delBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dtgvPOL);
            this.tabPage2.Controls.Add(this.dtgvPO);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PENDING";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(347, 354);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 41);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.Control;
            this.delBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.Black;
            this.delBtn.Location = new System.Drawing.Point(1026, 354);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(188, 41);
            this.delBtn.TabIndex = 24;
            this.delBtn.Text = "Delivered";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Visible = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(761, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "PURCHASE ORDER LINE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(118, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "PURCHASE ORDER";
            // 
            // dtgvPOL
            // 
            this.dtgvPOL.AllowUserToAddRows = false;
            this.dtgvPOL.AllowUserToDeleteRows = false;
            this.dtgvPOL.AllowUserToResizeColumns = false;
            this.dtgvPOL.AllowUserToResizeRows = false;
            this.dtgvPOL.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOL.Location = new System.Drawing.Point(576, 45);
            this.dtgvPOL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPOL.Name = "dtgvPOL";
            this.dtgvPOL.ReadOnly = true;
            this.dtgvPOL.RowHeadersVisible = false;
            this.dtgvPOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOL.Size = new System.Drawing.Size(638, 301);
            this.dtgvPOL.TabIndex = 2;
            this.dtgvPOL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPOL_CellClick);
            // 
            // dtgvPO
            // 
            this.dtgvPO.AllowUserToAddRows = false;
            this.dtgvPO.AllowUserToDeleteRows = false;
            this.dtgvPO.AllowUserToResizeColumns = false;
            this.dtgvPO.AllowUserToResizeRows = false;
            this.dtgvPO.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPO.Location = new System.Drawing.Point(8, 45);
            this.dtgvPO.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPO.Name = "dtgvPO";
            this.dtgvPO.ReadOnly = true;
            this.dtgvPO.RowHeadersVisible = false;
            this.dtgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPO.Size = new System.Drawing.Size(474, 301);
            this.dtgvPO.TabIndex = 1;
            this.dtgvPO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPO_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dtgvPOLC);
            this.tabPage3.Controls.Add(this.dtgvPOC);
            this.tabPage3.Controls.Add(this.dataComplete);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1246, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "COMPLETED";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(768, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "PURCHASE ORDER LINE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(125, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "PURCHASE ORDER";
            // 
            // dtgvPOLC
            // 
            this.dtgvPOLC.AllowUserToAddRows = false;
            this.dtgvPOLC.AllowUserToDeleteRows = false;
            this.dtgvPOLC.AllowUserToResizeColumns = false;
            this.dtgvPOLC.AllowUserToResizeRows = false;
            this.dtgvPOLC.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOLC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOLC.Location = new System.Drawing.Point(569, 47);
            this.dtgvPOLC.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPOLC.Name = "dtgvPOLC";
            this.dtgvPOLC.ReadOnly = true;
            this.dtgvPOLC.RowHeadersVisible = false;
            this.dtgvPOLC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOLC.Size = new System.Drawing.Size(638, 301);
            this.dtgvPOLC.TabIndex = 23;
            // 
            // dtgvPOC
            // 
            this.dtgvPOC.AllowUserToAddRows = false;
            this.dtgvPOC.AllowUserToDeleteRows = false;
            this.dtgvPOC.AllowUserToResizeColumns = false;
            this.dtgvPOC.AllowUserToResizeRows = false;
            this.dtgvPOC.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOC.Location = new System.Drawing.Point(15, 47);
            this.dtgvPOC.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPOC.Name = "dtgvPOC";
            this.dtgvPOC.ReadOnly = true;
            this.dtgvPOC.RowHeadersVisible = false;
            this.dtgvPOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOC.Size = new System.Drawing.Size(474, 301);
            this.dtgvPOC.TabIndex = 22;
            this.dtgvPOC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPOC_CellClick);
            // 
            // dataComplete
            // 
            this.dataComplete.AllowUserToAddRows = false;
            this.dataComplete.AllowUserToDeleteRows = false;
            this.dataComplete.AllowUserToResizeColumns = false;
            this.dataComplete.AllowUserToResizeRows = false;
            this.dataComplete.BackgroundColor = System.Drawing.Color.White;
            this.dataComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataComplete.Location = new System.Drawing.Point(4, 4);
            this.dataComplete.Margin = new System.Windows.Forms.Padding(4);
            this.dataComplete.Name = "dataComplete";
            this.dataComplete.ReadOnly = true;
            this.dataComplete.RowHeadersVisible = false;
            this.dataComplete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataComplete.Size = new System.Drawing.Size(1238, 511);
            this.dataComplete.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.dtgvPOLCL);
            this.tabPage4.Controls.Add(this.dtgvPOCL);
            this.tabPage4.Controls.Add(this.dataCancel);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1246, 410);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CANCELLED";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(776, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "PURCHASE ORDER LINE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(133, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "PURCHASE ORDER";
            // 
            // dtgvPOLCL
            // 
            this.dtgvPOLCL.AllowUserToAddRows = false;
            this.dtgvPOLCL.AllowUserToDeleteRows = false;
            this.dtgvPOLCL.AllowUserToResizeColumns = false;
            this.dtgvPOLCL.AllowUserToResizeRows = false;
            this.dtgvPOLCL.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOLCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOLCL.Location = new System.Drawing.Point(577, 58);
            this.dtgvPOLCL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPOLCL.Name = "dtgvPOLCL";
            this.dtgvPOLCL.ReadOnly = true;
            this.dtgvPOLCL.RowHeadersVisible = false;
            this.dtgvPOLCL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOLCL.Size = new System.Drawing.Size(638, 301);
            this.dtgvPOLCL.TabIndex = 23;
            // 
            // dtgvPOCL
            // 
            this.dtgvPOCL.AllowUserToAddRows = false;
            this.dtgvPOCL.AllowUserToDeleteRows = false;
            this.dtgvPOCL.AllowUserToResizeColumns = false;
            this.dtgvPOCL.AllowUserToResizeRows = false;
            this.dtgvPOCL.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOCL.Location = new System.Drawing.Point(23, 58);
            this.dtgvPOCL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvPOCL.Name = "dtgvPOCL";
            this.dtgvPOCL.ReadOnly = true;
            this.dtgvPOCL.RowHeadersVisible = false;
            this.dtgvPOCL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOCL.Size = new System.Drawing.Size(474, 301);
            this.dtgvPOCL.TabIndex = 22;
            this.dtgvPOCL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPOCL_CellClick);
            // 
            // dataCancel
            // 
            this.dataCancel.AllowUserToAddRows = false;
            this.dataCancel.AllowUserToDeleteRows = false;
            this.dataCancel.AllowUserToResizeColumns = false;
            this.dataCancel.AllowUserToResizeRows = false;
            this.dataCancel.BackgroundColor = System.Drawing.Color.White;
            this.dataCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCancel.Location = new System.Drawing.Point(4, 4);
            this.dataCancel.Margin = new System.Windows.Forms.Padding(4);
            this.dataCancel.Name = "dataCancel";
            this.dataCancel.ReadOnly = true;
            this.dataCancel.RowHeadersVisible = false;
            this.dataCancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCancel.Size = new System.Drawing.Size(1238, 511);
            this.dataCancel.TabIndex = 3;
            // 
            // orderlistmgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 988);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "orderlistmgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderlistmgt";
            this.Load += new System.EventHandler(this.orderlistmgt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPO)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataComplete)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOLCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgvOrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvPOL;
        private System.Windows.Forms.DataGridView dtgvPO;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataComplete;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataCancel;
        private System.Windows.Forms.NumericUpDown quanNum;
        private System.Windows.Forms.TextBox vendorName;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgvPOLC;
        private System.Windows.Forms.DataGridView dtgvPOC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgvPOLCL;
        private System.Windows.Forms.DataGridView dtgvPOCL;
    }
}
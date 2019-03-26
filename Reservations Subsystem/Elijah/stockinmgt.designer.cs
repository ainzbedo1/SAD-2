namespace Reservations_Subsystem
{
    partial class stockinmgt
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvInv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvPO = new System.Windows.Forms.DataGridView();
            this.btnin = new System.Windows.Forms.Button();
            this.dtgvPOL = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.StockInBtn = new System.Windows.Forms.Button();
            this.expirationDtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOL)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvInv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(460, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(515, 490);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory Preview";
            // 
            // dtgvInv
            // 
            this.dtgvInv.AllowUserToAddRows = false;
            this.dtgvInv.AllowUserToDeleteRows = false;
            this.dtgvInv.AllowUserToResizeColumns = false;
            this.dtgvInv.AllowUserToResizeRows = false;
            this.dtgvInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInv.BackgroundColor = System.Drawing.Color.White;
            this.dtgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInv.Location = new System.Drawing.Point(14, 36);
            this.dtgvInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvInv.Name = "dtgvInv";
            this.dtgvInv.ReadOnly = true;
            this.dtgvInv.RowHeadersVisible = false;
            this.dtgvInv.RowTemplate.Height = 24;
            this.dtgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInv.Size = new System.Drawing.Size(489, 427);
            this.dtgvInv.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvPO);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(434, 490);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Delivered Orders";
            // 
            // dtgvPO
            // 
            this.dtgvPO.AllowUserToAddRows = false;
            this.dtgvPO.AllowUserToDeleteRows = false;
            this.dtgvPO.AllowUserToResizeColumns = false;
            this.dtgvPO.AllowUserToResizeRows = false;
            this.dtgvPO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPO.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPO.Location = new System.Drawing.Point(11, 26);
            this.dtgvPO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvPO.Name = "dtgvPO";
            this.dtgvPO.ReadOnly = true;
            this.dtgvPO.RowHeadersVisible = false;
            this.dtgvPO.RowTemplate.Height = 24;
            this.dtgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPO.Size = new System.Drawing.Size(400, 175);
            this.dtgvPO.TabIndex = 8;
            this.dtgvPO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPO_CellClick);
            // 
            // btnin
            // 
            this.btnin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnin.BackColor = System.Drawing.Color.DarkGreen;
            this.btnin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(162)))), ((int)(((byte)(23)))));
            this.btnin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(172)))), ((int)(((byte)(41)))));
            this.btnin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.White;
            this.btnin.Location = new System.Drawing.Point(-117, 227);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(83, 31);
            this.btnin.TabIndex = 58;
            this.btnin.Text = "Stock-in";
            this.btnin.UseVisualStyleBackColor = false;
            // 
            // dtgvPOL
            // 
            this.dtgvPOL.AllowUserToAddRows = false;
            this.dtgvPOL.AllowUserToDeleteRows = false;
            this.dtgvPOL.AllowUserToResizeColumns = false;
            this.dtgvPOL.AllowUserToResizeRows = false;
            this.dtgvPOL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvPOL.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPOL.Location = new System.Drawing.Point(4, 26);
            this.dtgvPOL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvPOL.Name = "dtgvPOL";
            this.dtgvPOL.ReadOnly = true;
            this.dtgvPOL.RowHeadersVisible = false;
            this.dtgvPOL.RowTemplate.Height = 24;
            this.dtgvPOL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPOL.Size = new System.Drawing.Size(400, 162);
            this.dtgvPOL.TabIndex = 59;
            this.dtgvPOL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPOL_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb);
            this.groupBox3.Controls.Add(this.StockInBtn);
            this.groupBox3.Controls.Add(this.expirationDtp);
            this.groupBox3.Controls.Add(this.btnin);
            this.groupBox3.Controls.Add(this.dtgvPOL);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 270);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(434, 263);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivered Order Line";
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Checked = true;
            this.cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb.Location = new System.Drawing.Point(10, 194);
            this.cb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(113, 28);
            this.cb.TabIndex = 159;
            this.cb.Text = "Expiration";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // StockInBtn
            // 
            this.StockInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInBtn.Location = new System.Drawing.Point(320, 222);
            this.StockInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StockInBtn.Name = "StockInBtn";
            this.StockInBtn.Size = new System.Drawing.Size(91, 34);
            this.StockInBtn.TabIndex = 61;
            this.StockInBtn.Text = "Stock In";
            this.StockInBtn.UseVisualStyleBackColor = true;
            this.StockInBtn.Click += new System.EventHandler(this.StockInBtn_Click);
            // 
            // expirationDtp
            // 
            this.expirationDtp.CustomFormat = "yyyy-MM-dd";
            this.expirationDtp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationDtp.Location = new System.Drawing.Point(11, 224);
            this.expirationDtp.Name = "expirationDtp";
            this.expirationDtp.Size = new System.Drawing.Size(149, 26);
            this.expirationDtp.TabIndex = 158;
            // 
            // stockinmgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "stockinmgt";
            this.Text = "stockinmgt";
            this.Load += new System.EventHandler(this.stockinmgt_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPOL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dtgvInv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.DataGridView dtgvPO;
        private System.Windows.Forms.DataGridView dtgvPOL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker expirationDtp;
        private System.Windows.Forms.Button StockInBtn;
        private System.Windows.Forms.CheckBox cb;
    }
}
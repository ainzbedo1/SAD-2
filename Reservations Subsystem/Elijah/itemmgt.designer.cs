namespace Reservations_Subsystem
{
    partial class itemmgt
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsell = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.TextBox();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.dtgv_itemmgt = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Label();
            this.cmbSup = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_itemmgt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1002, 614);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(167, 88);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(818, 614);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(169, 88);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSup);
            this.groupBox1.Controls.Add(this.Supplier);
            this.groupBox1.Controls.Add(this.txtsell);
            this.groupBox1.Controls.Add(this.txtcost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtitemcode);
            this.groupBox1.Controls.Add(this.txtitemname);
            this.groupBox1.Controls.Add(this.lblitemcode);
            this.groupBox1.Controls.Add(this.lblitemname);
            this.groupBox1.Controls.Add(this.lbldesc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // txtsell
            // 
            this.txtsell.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsell.Location = new System.Drawing.Point(777, 41);
            this.txtsell.Margin = new System.Windows.Forms.Padding(4);
            this.txtsell.Name = "txtsell";
            this.txtsell.Size = new System.Drawing.Size(358, 39);
            this.txtsell.TabIndex = 13;
            // 
            // txtcost
            // 
            this.txtcost.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcost.Location = new System.Drawing.Point(777, 97);
            this.txtcost.Margin = new System.Windows.Forms.Padding(4);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(358, 39);
            this.txtcost.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(610, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cost Price:";
            // 
            // txtitemcode
            // 
            this.txtitemcode.Enabled = false;
            this.txtitemcode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemcode.Location = new System.Drawing.Point(198, 48);
            this.txtitemcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(107, 39);
            this.txtitemcode.TabIndex = 5;
            // 
            // txtitemname
            // 
            this.txtitemname.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(198, 94);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(4);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(364, 39);
            this.txtitemname.TabIndex = 7;
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemcode.ForeColor = System.Drawing.Color.Black;
            this.lblitemcode.Location = new System.Drawing.Point(39, 44);
            this.lblitemcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(152, 32);
            this.lblitemcode.TabIndex = 6;
            this.lblitemcode.Text = "Item Code:";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemname.ForeColor = System.Drawing.Color.Black;
            this.lblitemname.Location = new System.Drawing.Point(32, 97);
            this.lblitemname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(159, 32);
            this.lblitemname.TabIndex = 8;
            this.lblitemname.Text = "Item Name:";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.Black;
            this.lbldesc.Location = new System.Drawing.Point(610, 48);
            this.lbldesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(136, 32);
            this.lbldesc.TabIndex = 10;
            this.lbldesc.Text = "Sell Price";
            // 
            // dtgv_itemmgt
            // 
            this.dtgv_itemmgt.AllowUserToAddRows = false;
            this.dtgv_itemmgt.AllowUserToDeleteRows = false;
            this.dtgv_itemmgt.AllowUserToResizeColumns = false;
            this.dtgv_itemmgt.AllowUserToResizeRows = false;
            this.dtgv_itemmgt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_itemmgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_itemmgt.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_itemmgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_itemmgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_itemmgt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_itemmgt.Location = new System.Drawing.Point(7, 69);
            this.dtgv_itemmgt.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_itemmgt.Name = "dtgv_itemmgt";
            this.dtgv_itemmgt.ReadOnly = true;
            this.dtgv_itemmgt.RowHeadersVisible = false;
            this.dtgv_itemmgt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_itemmgt.Size = new System.Drawing.Size(1180, 330);
            this.dtgv_itemmgt.TabIndex = 9;
            this.dtgv_itemmgt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_itemmgt_CellClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(629, 614);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(169, 88);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1024, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Archived List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(444, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 88);
            this.button2.TabIndex = 14;
            this.button2.Text = "ARCHIVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Supplier
            // 
            this.Supplier.AutoSize = true;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.ForeColor = System.Drawing.Color.Black;
            this.Supplier.Location = new System.Drawing.Point(625, 147);
            this.Supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(121, 32);
            this.Supplier.TabIndex = 15;
            this.Supplier.Text = "Supplier";
            // 
            // cmbSup
            // 
            this.cmbSup.FormattingEnabled = true;
            this.cmbSup.Location = new System.Drawing.Point(777, 143);
            this.cmbSup.Name = "cmbSup";
            this.cmbSup.Size = new System.Drawing.Size(358, 44);
            this.cmbSup.TabIndex = 16;
            // 
            // itemmgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 739);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgv_itemmgt);
            this.Controls.Add(this.button1);
            this.Name = "itemmgt";
            this.Text = "itemmgt";
            this.Load += new System.EventHandler(this.itemmgt_Load);
            this.Click += new System.EventHandler(this.itemmgt_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_itemmgt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtitemcode;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.Label lblitemcode;
        private System.Windows.Forms.Label lblitemname;
        private System.Windows.Forms.Label lbldesc;
        public System.Windows.Forms.DataGridView dtgv_itemmgt;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox txtsell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Supplier;
        private System.Windows.Forms.ComboBox cmbSup;
    }
}
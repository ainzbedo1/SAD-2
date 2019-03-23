namespace Hotel_Inventory
{
    partial class Inventorymgt
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
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_items = new System.Windows.Forms.Button();
            this.btn_stockin = new System.Windows.Forms.Button();
            this.btn_orderlistmgt = new System.Windows.Forms.Button();
            this.datagridview_inventory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_stockoutlist = new System.Windows.Forms.Button();
            this.btn_stockout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_inventory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(1001, 419);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(236, 81);
            this.btn_dashboard.TabIndex = 10;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_items
            // 
            this.btn_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Location = new System.Drawing.Point(467, 547);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(221, 89);
            this.btn_items.TabIndex = 8;
            this.btn_items.Text = "Item Management";
            this.btn_items.UseVisualStyleBackColor = true;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // btn_stockin
            // 
            this.btn_stockin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stockin.Location = new System.Drawing.Point(240, 547);
            this.btn_stockin.Name = "btn_stockin";
            this.btn_stockin.Size = new System.Drawing.Size(221, 89);
            this.btn_stockin.TabIndex = 7;
            this.btn_stockin.Text = "Stock-in Management";
            this.btn_stockin.UseVisualStyleBackColor = true;
            this.btn_stockin.Click += new System.EventHandler(this.btn_stockin_Click);
            // 
            // btn_orderlistmgt
            // 
            this.btn_orderlistmgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderlistmgt.Location = new System.Drawing.Point(13, 547);
            this.btn_orderlistmgt.Name = "btn_orderlistmgt";
            this.btn_orderlistmgt.Size = new System.Drawing.Size(221, 89);
            this.btn_orderlistmgt.TabIndex = 6;
            this.btn_orderlistmgt.Text = "Order List Management";
            this.btn_orderlistmgt.UseVisualStyleBackColor = true;
            this.btn_orderlistmgt.Click += new System.EventHandler(this.btn_orderlistmgt_Click);
            // 
            // datagridview_inventory
            // 
            this.datagridview_inventory.AllowUserToAddRows = false;
            this.datagridview_inventory.AllowUserToDeleteRows = false;
            this.datagridview_inventory.AllowUserToResizeColumns = false;
            this.datagridview_inventory.AllowUserToResizeRows = false;
            this.datagridview_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_inventory.BackgroundColor = System.Drawing.Color.White;
            this.datagridview_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_inventory.Location = new System.Drawing.Point(7, 41);
            this.datagridview_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.datagridview_inventory.Name = "datagridview_inventory";
            this.datagridview_inventory.ReadOnly = true;
            this.datagridview_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_inventory.Size = new System.Drawing.Size(1210, 337);
            this.datagridview_inventory.TabIndex = 2;
            this.datagridview_inventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_inventory_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_stockoutlist);
            this.groupBox2.Controls.Add(this.btn_stockout);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock-out Details";
            // 
            // btn_stockoutlist
            // 
            this.btn_stockoutlist.Location = new System.Drawing.Point(12, 69);
            this.btn_stockoutlist.Name = "btn_stockoutlist";
            this.btn_stockoutlist.Size = new System.Drawing.Size(257, 48);
            this.btn_stockoutlist.TabIndex = 36;
            this.btn_stockoutlist.Text = "View Stock-out List";
            this.btn_stockoutlist.UseVisualStyleBackColor = true;
            this.btn_stockoutlist.Click += new System.EventHandler(this.btn_stockoutlist_Click);
            // 
            // btn_stockout
            // 
            this.btn_stockout.Location = new System.Drawing.Point(584, 25);
            this.btn_stockout.Name = "btn_stockout";
            this.btn_stockout.Size = new System.Drawing.Size(134, 69);
            this.btn_stockout.TabIndex = 35;
            this.btn_stockout.Text = "Stock-out";
            this.btn_stockout.UseVisualStyleBackColor = true;
            this.btn_stockout.Click += new System.EventHandler(this.btn_stockout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "ENTER QUANTITY:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(216, 20);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 40);
            this.textBox2.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagridview_inventory);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 385);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory List";
            // 
            // Inventorymgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 661);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_orderlistmgt);
            this.Controls.Add(this.btn_items);
            this.Controls.Add(this.btn_stockin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inventorymgt";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventorymgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_inventory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Button btn_stockin;
        private System.Windows.Forms.Button btn_orderlistmgt;
        private System.Windows.Forms.DataGridView datagridview_inventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_stockoutlist;
        private System.Windows.Forms.Button btn_stockout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


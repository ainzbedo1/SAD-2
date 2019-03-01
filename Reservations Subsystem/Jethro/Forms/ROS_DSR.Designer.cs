namespace Reservations_Subsystem
{
    partial class ROS_DSR
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
            this.backButton = new System.Windows.Forms.Button();
            this.DSRGridView = new System.Windows.Forms.DataGridView();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderTopPanel = new System.Windows.Forms.Panel();
            this.DSRPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderReceiptsGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthValue = new System.Windows.Forms.ComboBox();
            this.yearValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DSRGridView)).BeginInit();
            this.OrderTopPanel.SuspendLayout();
            this.DSRPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderReceiptsGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(1110, 524);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 64);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DSRGridView
            // 
            this.DSRGridView.AllowUserToAddRows = false;
            this.DSRGridView.AllowUserToDeleteRows = false;
            this.DSRGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSRGridView.Location = new System.Drawing.Point(0, 49);
            this.DSRGridView.Name = "DSRGridView";
            this.DSRGridView.ReadOnly = true;
            this.DSRGridView.Size = new System.Drawing.Size(398, 449);
            this.DSRGridView.TabIndex = 2;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(2, 6);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(295, 37);
            this.OrderLabel.TabIndex = 7;
            this.OrderLabel.Text = "Daily Sales Reports";
            // 
            // OrderTopPanel
            // 
            this.OrderTopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTopPanel.Controls.Add(this.OrderLabel);
            this.OrderTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderTopPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderTopPanel.Name = "OrderTopPanel";
            this.OrderTopPanel.Size = new System.Drawing.Size(398, 49);
            this.OrderTopPanel.TabIndex = 0;
            // 
            // DSRPanel
            // 
            this.DSRPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DSRPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DSRPanel.Controls.Add(this.DSRGridView);
            this.DSRPanel.Controls.Add(this.OrderTopPanel);
            this.DSRPanel.Location = new System.Drawing.Point(12, 12);
            this.DSRPanel.Name = "DSRPanel";
            this.DSRPanel.Size = new System.Drawing.Size(400, 500);
            this.DSRPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.yearValue);
            this.MainPanel.Controls.Add(this.monthValue);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.label);
            this.MainPanel.Controls.Add(this.DSRPanel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.OrderPanel);
            this.MainPanel.Controls.Add(this.backButton);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1250, 600);
            this.MainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.orderReceiptsGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(424, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 500);
            this.panel1.TabIndex = 10;
            // 
            // orderReceiptsGridView
            // 
            this.orderReceiptsGridView.AllowUserToAddRows = false;
            this.orderReceiptsGridView.AllowUserToDeleteRows = false;
            this.orderReceiptsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderReceiptsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderReceiptsGridView.Location = new System.Drawing.Point(0, 49);
            this.orderReceiptsGridView.Name = "orderReceiptsGridView";
            this.orderReceiptsGridView.ReadOnly = true;
            this.orderReceiptsGridView.Size = new System.Drawing.Size(398, 449);
            this.orderReceiptsGridView.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 49);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Receipts";
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPanel.Controls.Add(this.ordersGridView);
            this.OrderPanel.Controls.Add(this.panel6);
            this.OrderPanel.Location = new System.Drawing.Point(836, 14);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(400, 500);
            this.OrderPanel.TabIndex = 11;
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGridView.Location = new System.Drawing.Point(0, 49);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.Size = new System.Drawing.Size(398, 449);
            this.ordersGridView.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 49);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Orders";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(223, 541);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 31);
            this.label.TabIndex = 12;
            this.label.Text = "Month:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Year:";
            // 
            // monthValue
            // 
            this.monthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthValue.FormattingEnabled = true;
            this.monthValue.Items.AddRange(new object[] {
            "1",
            "10",
            "11",
            "12",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.monthValue.Location = new System.Drawing.Point(323, 541);
            this.monthValue.Name = "monthValue";
            this.monthValue.Size = new System.Drawing.Size(89, 37);
            this.monthValue.Sorted = true;
            this.monthValue.TabIndex = 14;
            // 
            // yearValue
            // 
            this.yearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearValue.FormattingEnabled = true;
            this.yearValue.Location = new System.Drawing.Point(87, 541);
            this.yearValue.Name = "yearValue";
            this.yearValue.Size = new System.Drawing.Size(121, 37);
            this.yearValue.Sorted = true;
            this.yearValue.TabIndex = 15;
            // 
            // ROS_DSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1274, 622);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ROS_DSR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ROS_DSR_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DSRGridView)).EndInit();
            this.OrderTopPanel.ResumeLayout(false);
            this.OrderTopPanel.PerformLayout();
            this.DSRPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderReceiptsGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView DSRGridView;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Panel OrderTopPanel;
        private System.Windows.Forms.Panel DSRPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView orderReceiptsGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox yearValue;
        private System.Windows.Forms.ComboBox monthValue;
    }
}
﻿namespace Reservations_Subsystem
{
    partial class ROS_Main
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.viewDSRButton = new System.Windows.Forms.Button();
            this.viewMenuButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.OrderBottomPanel = new System.Windows.Forms.Panel();
            this.princeAmountLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.OrderTopPanel = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.MenuTopPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.menuSearch = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.OrderBottomPanel.SuspendLayout();
            this.OrderTopPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.MenuTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.backButton);
            this.MainPanel.Controls.Add(this.viewDSRButton);
            this.MainPanel.Controls.Add(this.viewMenuButton);
            this.MainPanel.Controls.Add(this.clearButton);
            this.MainPanel.Controls.Add(this.createButton);
            this.MainPanel.Controls.Add(this.removeButton);
            this.MainPanel.Controls.Add(this.addButton);
            this.MainPanel.Controls.Add(this.OrderPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1115, 600);
            this.MainPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(975, 524);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(125, 64);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // viewDSRButton
            // 
            this.viewDSRButton.BackColor = System.Drawing.Color.Yellow;
            this.viewDSRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDSRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDSRButton.Location = new System.Drawing.Point(501, 524);
            this.viewDSRButton.Name = "viewDSRButton";
            this.viewDSRButton.Size = new System.Drawing.Size(177, 64);
            this.viewDSRButton.TabIndex = 8;
            this.viewDSRButton.Text = "View DSR";
            this.viewDSRButton.UseVisualStyleBackColor = false;
            this.viewDSRButton.Click += new System.EventHandler(this.viewDSRButton_Click);
            // 
            // viewMenuButton
            // 
            this.viewMenuButton.BackColor = System.Drawing.Color.Yellow;
            this.viewMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenuButton.Location = new System.Drawing.Point(690, 524);
            this.viewMenuButton.Name = "viewMenuButton";
            this.viewMenuButton.Size = new System.Drawing.Size(177, 64);
            this.viewMenuButton.TabIndex = 7;
            this.viewMenuButton.Text = "View Menu";
            this.viewMenuButton.UseVisualStyleBackColor = false;
            this.viewMenuButton.Click += new System.EventHandler(this.viewMenuButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(287, 524);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 64);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Lime;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(12, 524);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(125, 64);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Maroon;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.Black;
            this.removeButton.Location = new System.Drawing.Point(424, 296);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(65, 41);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = ">>";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Green;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(424, 187);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 41);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "<<";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPanel.Controls.Add(this.orderGridView);
            this.OrderPanel.Controls.Add(this.OrderBottomPanel);
            this.OrderPanel.Controls.Add(this.OrderTopPanel);
            this.OrderPanel.Location = new System.Drawing.Point(12, 12);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(400, 500);
            this.OrderPanel.TabIndex = 0;
            // 
            // orderGridView
            // 
            this.orderGridView.AllowUserToAddRows = false;
            this.orderGridView.AllowUserToDeleteRows = false;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderGridView.Location = new System.Drawing.Point(0, 49);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.ReadOnly = true;
            this.orderGridView.Size = new System.Drawing.Size(398, 400);
            this.orderGridView.TabIndex = 2;
            // 
            // OrderBottomPanel
            // 
            this.OrderBottomPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderBottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderBottomPanel.Controls.Add(this.princeAmountLabel);
            this.OrderBottomPanel.Controls.Add(this.priceLabel);
            this.OrderBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderBottomPanel.Location = new System.Drawing.Point(0, 449);
            this.OrderBottomPanel.Name = "OrderBottomPanel";
            this.OrderBottomPanel.Size = new System.Drawing.Size(398, 49);
            this.OrderBottomPanel.TabIndex = 1;
            // 
            // princeAmountLabel
            // 
            this.princeAmountLabel.AutoSize = true;
            this.princeAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.princeAmountLabel.Location = new System.Drawing.Point(145, 6);
            this.princeAmountLabel.Name = "princeAmountLabel";
            this.princeAmountLabel.Size = new System.Drawing.Size(101, 37);
            this.princeAmountLabel.TabIndex = 8;
            this.princeAmountLabel.Text = "P0.00";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(2, 6);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(137, 37);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "PRICE: ";
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
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(2, 6);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(135, 37);
            this.OrderLabel.TabIndex = 7;
            this.OrderLabel.Text = "ORDER";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.menuGridView);
            this.MenuPanel.Controls.Add(this.MenuTopPanel);
            this.MenuPanel.Location = new System.Drawing.Point(501, 12);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(600, 500);
            this.MenuPanel.TabIndex = 1;
            // 
            // menuGridView
            // 
            this.menuGridView.AllowUserToAddRows = false;
            this.menuGridView.AllowUserToDeleteRows = false;
            this.menuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuGridView.Location = new System.Drawing.Point(0, 49);
            this.menuGridView.Name = "menuGridView";
            this.menuGridView.ReadOnly = true;
            this.menuGridView.Size = new System.Drawing.Size(598, 449);
            this.menuGridView.TabIndex = 3;
            // 
            // MenuTopPanel
            // 
            this.MenuTopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuTopPanel.Controls.Add(this.MenuLabel);
            this.MenuTopPanel.Controls.Add(this.menuSearch);
            this.MenuTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuTopPanel.Name = "MenuTopPanel";
            this.MenuTopPanel.Size = new System.Drawing.Size(598, 49);
            this.MenuTopPanel.TabIndex = 1;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(3, 6);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(115, 37);
            this.MenuLabel.TabIndex = 7;
            this.MenuLabel.Text = "MENU";
            // 
            // menuSearch
            // 
            this.menuSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSearch.Location = new System.Drawing.Point(331, 6);
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(259, 35);
            this.menuSearch.TabIndex = 4;
            // 
            // ROS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1139, 622);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ROS_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ROS_Main_FormClosing);
            this.MainPanel.ResumeLayout(false);
            this.OrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.OrderBottomPanel.ResumeLayout(false);
            this.OrderBottomPanel.PerformLayout();
            this.OrderTopPanel.ResumeLayout(false);
            this.OrderTopPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.MenuTopPanel.ResumeLayout(false);
            this.MenuTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MenuTopPanel;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.TextBox menuSearch;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Panel OrderTopPanel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Panel OrderBottomPanel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button viewDSRButton;
        private System.Windows.Forms.Button viewMenuButton;
        private System.Windows.Forms.Label princeAmountLabel;
    }
}
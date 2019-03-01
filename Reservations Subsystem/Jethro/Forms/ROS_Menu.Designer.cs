namespace Reservations_Subsystem
{
    partial class ROS_Menu
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
            this.menuGridView = new System.Windows.Forms.DataGridView();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.MenuTopPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.menuSearch = new System.Windows.Forms.TextBox();
            this.OrderTopPanel = new System.Windows.Forms.Panel();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewDSRButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).BeginInit();
            this.MenuTopPanel.SuspendLayout();
            this.OrderTopPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
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
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(2, 6);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(157, 37);
            this.DetailsLabel.TabIndex = 7;
            this.DetailsLabel.Text = "DETAILS";
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
            // OrderTopPanel
            // 
            this.OrderTopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OrderTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderTopPanel.Controls.Add(this.DetailsLabel);
            this.OrderTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderTopPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderTopPanel.Name = "OrderTopPanel";
            this.OrderTopPanel.Size = new System.Drawing.Size(398, 49);
            this.OrderTopPanel.TabIndex = 0;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderPanel.Controls.Add(this.panel1);
            this.OrderPanel.Controls.Add(this.OrderTopPanel);
            this.OrderPanel.Location = new System.Drawing.Point(12, 12);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(400, 500);
            this.OrderPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priceTxt);
            this.panel1.Controls.Add(this.itemNameTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 449);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingredients:";
            // 
            // priceTxt
            // 
            this.priceTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(9, 129);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(259, 35);
            this.priceTxt.TabIndex = 10;
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTxt.Location = new System.Drawing.Point(9, 55);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(259, 35);
            this.itemNameTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Item Name:";
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.viewDSRButton);
            this.MainPanel.Controls.Add(this.clearButton);
            this.MainPanel.Controls.Add(this.createButton);
            this.MainPanel.Controls.Add(this.backButton);
            this.MainPanel.Controls.Add(this.OrderPanel);
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1115, 600);
            this.MainPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(638, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 64);
            this.button2.TabIndex = 14;
            this.button2.Text = "Archive";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // viewDSRButton
            // 
            this.viewDSRButton.BackColor = System.Drawing.Color.Yellow;
            this.viewDSRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDSRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDSRButton.Location = new System.Drawing.Point(501, 524);
            this.viewDSRButton.Name = "viewDSRButton";
            this.viewDSRButton.Size = new System.Drawing.Size(125, 64);
            this.viewDSRButton.TabIndex = 12;
            this.viewDSRButton.Text = "Edit";
            this.viewDSRButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Red;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(149, 524);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 64);
            this.clearButton.TabIndex = 11;
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
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            // 
            // ROS_Menu
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
            this.Name = "ROS_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ROS_Menu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView)).EndInit();
            this.MenuTopPanel.ResumeLayout(false);
            this.MenuTopPanel.PerformLayout();
            this.OrderTopPanel.ResumeLayout(false);
            this.OrderTopPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView menuGridView;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Panel MenuTopPanel;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.TextBox menuSearch;
        private System.Windows.Forms.Panel OrderTopPanel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewDSRButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
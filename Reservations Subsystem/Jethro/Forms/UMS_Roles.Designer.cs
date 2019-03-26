namespace Reservations_Subsystem
{
    partial class UMS_Roles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createButton = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roleTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesGridView = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.inv = new System.Windows.Forms.CheckBox();
            this.res = new System.Windows.Forms.CheckBox();
            this.pos = new System.Windows.Forms.CheckBox();
            this.menu = new System.Windows.Forms.CheckBox();
            this.user = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(27, 550);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 47;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // idText
            // 
            this.idText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(150, 42);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(125, 28);
            this.idText.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(27, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 37);
            this.label6.TabIndex = 46;
            this.label6.Text = "Role ID: ";
            // 
            // roleTitle
            // 
            this.roleTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTitle.Location = new System.Drawing.Point(34, 136);
            this.roleTitle.Name = "roleTitle";
            this.roleTitle.Size = new System.Drawing.Size(376, 28);
            this.roleTitle.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "Role Title:";
            // 
            // rolesGridView
            // 
            this.rolesGridView.AllowUserToAddRows = false;
            this.rolesGridView.AllowUserToDeleteRows = false;
            this.rolesGridView.AllowUserToResizeColumns = false;
            this.rolesGridView.AllowUserToResizeRows = false;
            this.rolesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rolesGridView.BackgroundColor = System.Drawing.Color.White;
            this.rolesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rolesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rolesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.rolesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.rolesGridView.Location = new System.Drawing.Point(464, 110);
            this.rolesGridView.MultiSelect = false;
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.ReadOnly = true;
            this.rolesGridView.RowHeadersVisible = false;
            this.rolesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesGridView.Size = new System.Drawing.Size(517, 449);
            this.rolesGridView.TabIndex = 40;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(526, 81);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 48;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(150, 550);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 49;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // inv
            // 
            this.inv.AutoSize = true;
            this.inv.Location = new System.Drawing.Point(104, 193);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(70, 17);
            this.inv.TabIndex = 57;
            this.inv.Text = "Inventory";
            this.inv.UseVisualStyleBackColor = true;
            this.inv.CheckedChanged += new System.EventHandler(this.inv_CheckedChanged);
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(104, 217);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(88, 17);
            this.res.TabIndex = 58;
            this.res.Text = "Reservations";
            this.res.UseVisualStyleBackColor = true;
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Location = new System.Drawing.Point(104, 240);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(91, 17);
            this.pos.TabIndex = 59;
            this.pos.Text = "Point of Sales";
            this.pos.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(104, 263);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(127, 17);
            this.menu.TabIndex = 60;
            this.menu.Text = "Point of Sales (Menu)";
            this.menu.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(104, 286);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(113, 17);
            this.user.TabIndex = 61;
            this.user.Text = "User Management";
            this.user.UseVisualStyleBackColor = true;
            // 
            // UMS_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.user);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.res);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roleTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolesGridView);
            this.Name = "UMS_Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMS_Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UMS_Roles_FormClosing);
            this.Load += new System.EventHandler(this.UMS_Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roleTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rolesGridView;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox inv;
        private System.Windows.Forms.CheckBox res;
        private System.Windows.Forms.CheckBox pos;
        private System.Windows.Forms.CheckBox menu;
        private System.Windows.Forms.CheckBox user;
    }
}
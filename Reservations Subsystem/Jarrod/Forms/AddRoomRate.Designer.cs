namespace Reservations_Subsystem
{
    partial class AddRoomRate
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
            this.cmbRoomTypes = new System.Windows.Forms.ComboBox();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbRoomTypes
            // 
            this.cmbRoomTypes.FormattingEnabled = true;
            this.cmbRoomTypes.Location = new System.Drawing.Point(35, 78);
            this.cmbRoomTypes.Name = "cmbRoomTypes";
            this.cmbRoomTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomTypes.TabIndex = 0;
            this.cmbRoomTypes.SelectedIndexChanged += new System.EventHandler(this.cmbRoomTypes_SelectedIndexChanged);
            this.cmbRoomTypes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRoomTypes_KeyPress);
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(180, 79);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(104, 20);
            this.txtRoomRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Types:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Room Rate:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add RoomRate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRoomRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.cmbRoomTypes);
            this.Name = "AddRoomRate";
            this.Text = "AddRoomRate";
            this.Load += new System.EventHandler(this.AddRoomRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoomTypes;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
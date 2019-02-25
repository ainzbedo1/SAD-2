namespace Reservations_Subsystem
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
            this.orderPanel = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.orderPanel2 = new System.Windows.Forms.Panel();
            this.menuPanel2 = new System.Windows.Forms.Panel();
            this.orderPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.orderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderPanel.Controls.Add(this.orderPanel2);
            this.orderPanel.Location = new System.Drawing.Point(12, 12);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(430, 634);
            this.orderPanel.TabIndex = 0;
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(457, 126);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(65, 45);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "<<";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(457, 365);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(65, 45);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">>";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.menuPanel2);
            this.menuPanel.Location = new System.Drawing.Point(538, 12);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(800, 634);
            this.menuPanel.TabIndex = 1;
            // 
            // orderPanel2
            // 
            this.orderPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderPanel2.Location = new System.Drawing.Point(12, 12);
            this.orderPanel2.Name = "orderPanel2";
            this.orderPanel2.Size = new System.Drawing.Size(400, 500);
            this.orderPanel2.TabIndex = 1;
            // 
            // menuPanel2
            // 
            this.menuPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel2.Location = new System.Drawing.Point(12, 12);
            this.menuPanel2.Name = "menuPanel2";
            this.menuPanel2.Size = new System.Drawing.Size(550, 500);
            this.menuPanel2.TabIndex = 2;
            // 
            // ROS_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.orderPanel);
            this.Name = "ROS_Main";
            this.Text = "ROS_Main";
            this.orderPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Panel orderPanel2;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel menuPanel2;
    }
}
namespace Reservations_Subsystem
{
    partial class others
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
            this.btnCont = new System.Windows.Forms.Button();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.lblYr = new System.Windows.Forms.Label();
            this.tabSelection = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.tabSelection.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.btnCont.FlatAppearance.BorderSize = 0;
            this.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCont.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.btnCont.ForeColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(0, 167);
            this.btnCont.Margin = new System.Windows.Forms.Padding(0);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(393, 44);
            this.btnCont.TabIndex = 0;
            this.btnCont.Text = "CONTINUE";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // txtYr
            // 
            this.txtYr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYr.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.txtYr.ForeColor = System.Drawing.Color.White;
            this.txtYr.Location = new System.Drawing.Point(19, 85);
            this.txtYr.Name = "txtYr";
            this.txtYr.Size = new System.Drawing.Size(369, 36);
            this.txtYr.TabIndex = 1;
            this.txtYr.Text = "1960-2099";
            this.txtYr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYr.Enter += new System.EventHandler(this.txtYr_Enter);
            // 
            // lblYr
            // 
            this.lblYr.AutoSize = true;
            this.lblYr.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYr.ForeColor = System.Drawing.Color.White;
            this.lblYr.Location = new System.Drawing.Point(159, 55);
            this.lblYr.Name = "lblYr";
            this.lblYr.Size = new System.Drawing.Size(90, 25);
            this.lblYr.TabIndex = 2;
            this.lblYr.Text = "Type Year";
            // 
            // tabSelection
            // 
            this.tabSelection.Controls.Add(this.tabPage1);
            this.tabSelection.Controls.Add(this.tabPage2);
            this.tabSelection.Location = new System.Drawing.Point(-11, -23);
            this.tabSelection.Name = "tabSelection";
            this.tabSelection.SelectedIndex = 0;
            this.tabSelection.Size = new System.Drawing.Size(411, 198);
            this.tabSelection.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.lblYr);
            this.tabPage1.Controls.Add(this.txtYr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(403, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Controls.Add(this.lblMonth);
            this.tabPage2.Controls.Add(this.txtMonth);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(403, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(82, 54);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(250, 25);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Type month name or number";
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.txtMonth.ForeColor = System.Drawing.Color.White;
            this.txtMonth.Location = new System.Drawing.Point(19, 84);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(369, 36);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.Text = "January or 1";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.Enter += new System.EventHandler(this.txtMonth_Enter);
            // 
            // others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(393, 212);
            this.ControlBox = false;
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.tabSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "others";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.others_FormClosing);
            this.Load += new System.EventHandler(this.others_Load);
            this.tabSelection.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.Label lblYr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        public System.Windows.Forms.TabControl tabSelection;
    }
}
namespace Reservations_Subsystem
{
    partial class FrmOccupancy
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
            this.crvOccReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnMethdo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvOccReport
            // 
            this.crvOccReport.ActiveViewIndex = -1;
            this.crvOccReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvOccReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvOccReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvOccReport.Location = new System.Drawing.Point(0, 0);
            this.crvOccReport.Name = "crvOccReport";
            this.crvOccReport.Size = new System.Drawing.Size(800, 450);
            this.crvOccReport.TabIndex = 0;
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(481, 12);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(75, 23);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method 1";
            this.btnMethod.UseVisualStyleBackColor = true;
            // 
            // btnMethdo2
            // 
            this.btnMethdo2.Location = new System.Drawing.Point(582, 12);
            this.btnMethdo2.Name = "btnMethdo2";
            this.btnMethdo2.Size = new System.Drawing.Size(75, 23);
            this.btnMethdo2.TabIndex = 1;
            this.btnMethdo2.Text = "Method 2";
            this.btnMethdo2.UseVisualStyleBackColor = true;
            // 
            // FrmOccupancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMethdo2);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.crvOccReport);
            this.Name = "FrmOccupancy";
            this.RightToLeftLayout = true;
            this.Text = "Occupancy Report";
            this.Load += new System.EventHandler(this.FrmOccupancy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvOccReport;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnMethdo2;
    }
}
namespace Reservations_Subsystem
{
    partial class FrmStateAccount
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
            this.crvStateAcc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvStateAcc
            // 
            this.crvStateAcc.ActiveViewIndex = -1;
            this.crvStateAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvStateAcc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvStateAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvStateAcc.Location = new System.Drawing.Point(0, 0);
            this.crvStateAcc.Name = "crvStateAcc";
            this.crvStateAcc.Size = new System.Drawing.Size(800, 450);
            this.crvStateAcc.TabIndex = 0;
            // 
            // FrmStateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvStateAcc);
            this.Name = "FrmStateAccount";
            this.Text = "FrmStateAccount";
            this.Load += new System.EventHandler(this.FrmStateAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvStateAcc;
    }
}
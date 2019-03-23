namespace Reservations_Subsystem
{
    partial class MSR
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
            this.dgvMsr = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnGenerateMsr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMsr
            // 
            this.dgvMsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMsr.Location = new System.Drawing.Point(12, 46);
            this.dgvMsr.Name = "dgvMsr";
            this.dgvMsr.Size = new System.Drawing.Size(764, 405);
            this.dgvMsr.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(564, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // btnGenerateMsr
            // 
            this.btnGenerateMsr.Location = new System.Drawing.Point(39, 13);
            this.btnGenerateMsr.Name = "btnGenerateMsr";
            this.btnGenerateMsr.Size = new System.Drawing.Size(99, 23);
            this.btnGenerateMsr.TabIndex = 3;
            this.btnGenerateMsr.Text = "Generate MSR";
            this.btnGenerateMsr.UseVisualStyleBackColor = true;
            this.btnGenerateMsr.Click += new System.EventHandler(this.btnGenerateMsr_Click);
            // 
            // MSR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateMsr);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvMsr);
            this.Name = "MSR";
            this.Text = "MSR";
            this.Load += new System.EventHandler(this.MSR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMsr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMsr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnGenerateMsr;
    }
}
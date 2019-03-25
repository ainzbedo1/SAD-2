using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations_Subsystem
{
    public partial class others : Form
    {
        public String[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        public ReservationCalendarForm res { get; set; }
        public others()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            int go = 0, n = 0, m = 0;
            bool isNumeric = int.TryParse(txtMonth.Text, out n), isNumeric2 = int.TryParse(txtYr.Text, out m);
            if (tabSelection.SelectedIndex == 1)     // Setting Custom Month
            {
                if (!isNumeric)                         //  Setting Custom Month (String input)
                {
                    foreach (String now in month)
                    {
                        if (now.Equals(txtMonth.Text, StringComparison.InvariantCultureIgnoreCase))
                        {
                            int i = Array.IndexOf(month, now);
                            lblMonth.Text = now;
                            res.adjustCustom(0, res.monthString[i]);
                            go = 1;
                        }
                    }

                    if (go == 0)
                    {
                        MessageBox.Show("Please enter the correct month name or number.");
                        txtMonth.Text = "January or 1";
                    }
                }
                else                                    //  Setting Custom Month (Int input)
                {
                    if (int.Parse(txtMonth.Text) > 0 && int.Parse(txtMonth.Text) <= 12)
                    {
                        res.adjustCustom(0, res.monthString[int.Parse(txtMonth.Text) - 1]);
                        go = 1;
                    }
                    else
                    {
                        MessageBox.Show("Please enter the correct month name or number.");
                        txtMonth.Text = "January or 1";
                    }
                }
            }
            else                                    //  Setting Custom Year
            {
                if (isNumeric2 && int.Parse(txtYr.Text) >= 1960 && int.Parse(txtYr.Text) <= 2099)
                {
                    res.adjustCustom(1, txtYr.Text);
                    go = 1;
                }
                else
                {
                    MessageBox.Show("Please enter year within the range from 1960 to 2099.");
                    txtYr.Clear();
                }
            }
            if (go == 1)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void others_Load(object sender, EventArgs e)
        {

        }

        private void others_FormClosing(object sender, FormClosingEventArgs e)
        {
            res.Show();
        }

        private void txtMonth_Enter(object sender, EventArgs e)
        {
            txtMonth.Text = "";
        }

        private void txtYr_Enter(object sender, EventArgs e)
        {
            txtYr.Text = "";
        }
    }
}

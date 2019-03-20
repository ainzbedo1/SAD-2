using MySql.Data.MySqlClient;
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
    public partial class ROS_Main : Form
    {
        public ROS_Main()
        {
            InitializeComponent();
        }

        //
        private void viewDSRButton_Click(object sender, EventArgs e)
        {
            ROS_DSR ros = new ROS_DSR();
            ros.reference = this;
            this.Hide();
            ros.Show();
        }
        private void viewMenuButton_Click(object sender, EventArgs e)
        {
            ROS_Menu menu = new ROS_Menu();
            menu.reference = this;
            this.Hide();
            menu.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ROS_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Redirect to Main Menu
        }

        private void ROS_Main_Load(object sender, EventArgs e)
        {
            refreshMenu();
            menuGridView.ClearSelection();
            menuGridView.Columns[0].Visible = false;
            menuGridView.Columns[3].Visible = false;
            orderGridView.ClearSelection();
        }
        public void refreshMenu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM menuitem";
            //String Menu = "SELECT name AS Item, price AS Price FROM menuitem";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            menuGridView.DataSource = dt;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in orderGridView.Rows)
                {
                    try
                    {
                        orderGridView.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (orderGridView.Rows.Count > 1);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addItem();
        }
        private void menuGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addItem();
        }
        private void addItem()
        {
            string itemName = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;
            string price = menuGridView.SelectedRows[0].Cells[2].Value + string.Empty;

            foreach (DataGridViewRow row in menuGridView.SelectedRows)
            {
                foreach (DataGridViewRow row2 in orderGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains(itemName))
                    {
                        orderGridView.Rows.Add(itemName, price);
                    }
                }
            }

            /*
            string itemName = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;
            string price = menuGridView.SelectedRows[0].Cells[2].Value + string.Empty;

            itemNameTxt.Text = itemName;
            priceTxt.Text = price;

            createButton.Enabled = false;
            updateButton.Enabled = true;
            */
        }

        private void menuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = true;
        }

        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeButton.Enabled = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in orderGridView.SelectedRows)
            {
                orderGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }
    }
}

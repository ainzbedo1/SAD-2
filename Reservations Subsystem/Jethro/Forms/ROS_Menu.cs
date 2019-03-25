using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    public partial class ROS_Menu : Form
    {
        public int id;
        public ROS_Main reference { get; set; }
        public ROS_Menu()
        {
            InitializeComponent();
        }
        private void ROS_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
            reference.refreshMenu();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ROS_Menu_Load(object sender, EventArgs e)
        {
            refreshMenu();
            menuGridView.ClearSelection();
            menuGridView.Columns[0].Visible = false;
            menuGridView.Columns[3].Visible = false;
        }
        public void refreshMenu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM menuitem WHERE status = '1'";
            //String Menu = "SELECT name AS Item, price AS Price FROM menuitem WHERE status = '1'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            menuGridView.DataSource = dt;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemNameTxt.Clear();
            priceTxt.Clear();

            createButton.Enabled = true;
            updateButton.Enabled = false;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            id = Int32.Parse(menuGridView.SelectedRows[0].Cells[0].Value.ToString());
            string itemName = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;
            string price = menuGridView.SelectedRows[0].Cells[2].Value + string.Empty;

            itemNameTxt.Text = itemName;
            priceTxt.Text = price;

            createButton.Enabled = false;
            updateButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (itemNameTxt.Text != "" && priceTxt.Text != "")
            {
                String query1 = "INSERT INTO menuitem (name, price) VALUES ('" + itemNameTxt.Text + "'," + float.Parse(priceTxt.Text) + ")";
                DBConnect db = new DBConnect();
                MySqlConnection con = db.connect();
                con.Open();
                MySqlCommand com = new MySqlCommand(query1, con);
                com.ExecuteNonQuery();
                con.Close();
                refreshMenu();
            }
            else MessageBox.Show("Please fill in the textboxes.");
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            String query1 = ("UPDATE menuitem SET status = @status");
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            using (MySqlCommand cmd = new MySqlCommand(query1, con))
            {
                cmd.Parameters.AddWithValue("@status", 1);

                con.Open();
                int result = cmd.ExecuteNonQuery();

                //checking for errors
                if (result < 0)
                {
                    Console.WriteLine("Error editing data.");
                }
                else
                {
                    MessageBox.Show("Succesfully Updated!");

                }
                con.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            String query1 = ("UPDATE menuitem SET name = @name, price = @price WHERE id = " + id);
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            using (MySqlCommand cmd = new MySqlCommand(query1, con))
            {
                cmd.Parameters.AddWithValue("@name", itemNameTxt.Text);
                cmd.Parameters.AddWithValue("@price", priceTxt.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();

                //checking for errors
                if (result < 0)
                {
                    Console.WriteLine("Error editing data.");
                }
                else
                {
                    MessageBox.Show("Succesfully Updated!");

                }
                con.Close();
            }
            refreshMenu();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {

        }
    }
}

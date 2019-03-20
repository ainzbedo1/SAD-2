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
        public ROS_Main reference { get; set; }
        public ROS_Menu()
        {
            InitializeComponent();
        }
        private void ROS_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ROS_Menu_Load(object sender, EventArgs e)
        {
            refreshMenu();
            menuGridView.ClearSelection();
        }
        public void refreshMenu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            //String Menu = "SELECT * FROM menuitem";
            String Menu = "SELECT name AS Item, price AS Price FROM menuitem WHERE status = '1' ORDER BY price";
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
            string itemName = menuGridView.SelectedRows[0].Cells[0].Value + string.Empty;
            string price = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;

            itemNameTxt.Text = itemName;
            priceTxt.Text = price;

            createButton.Enabled = false;
            updateButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            String query1 = "INSERT INTO menuitem (name, price) VALUES (@name, @price)";
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
                    Console.WriteLine("Error inserting data into users_table!");
                }
                else
                {
                    MessageBox.Show("succesfully inserted");

                }
                con.Close();
            }
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
            String query1 = ("UPDATE menuitem SET name = @name, price = @price WHERE  ");
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
        }
    }
}

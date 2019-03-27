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
            menuGridView.Columns[5].Visible = false;
        }
        public void refreshMenu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM menuitem WHERE status = '1' && type = '1'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            menuGridView.DataSource = dt;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                id = Int32.Parse(menuGridView.SelectedRows[0].Cells[0].Value.ToString());
                string itemName = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                string price = menuGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                string costPrice = menuGridView.SelectedRows[0].Cells[3].Value + string.Empty;

                itemNameTxt.Text = itemName;
                priceTxt.Text = price;
                costPriceTxt.Text = costPrice;

                createButton.Enabled = false;
                updateButton.Enabled = true;
            }catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemNameTxt.Text != "" && priceTxt.Text != "")
                {
                    String query1 = "INSERT INTO menuitem (name, sell_price, cost_price) VALUES ('" + itemNameTxt.Text + "'," + float.Parse(priceTxt.Text) + "," + float.Parse(costPriceTxt.Text) + ")";
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    con.Open();
                    MySqlCommand com = new MySqlCommand(query1, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    refreshMenu();
                    MessageBox.Show("Item has been added!");
                }
                else MessageBox.Show("Please fill in the textboxes.");
            }catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                MessageBox.Show("Item already exists!");
            }

            clear();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String query1 = ("UPDATE menuitem SET status = !status WHERE name = '" + menuGridView.SelectedRows[0].Cells[1].Value.ToString() + "'");
                DBConnect db = new DBConnect();
                MySqlConnection con = db.connect();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@status", 0);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error editing data.");
                    }
                    else
                    {
                        MessageBox.Show("Item status has been updated.");
                    }
                    con.Close();
                }
                refreshMenu();

                clear();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                String query1 = ("UPDATE menuitem SET name = @name, sell_price = @sell_price, cost_price = @cost_price WHERE id = " + id);
                DBConnect db = new DBConnect();
                MySqlConnection con = db.connect();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@name", itemNameTxt.Text);
                    cmd.Parameters.AddWithValue("@sell_price", priceTxt.Text);
                    cmd.Parameters.AddWithValue("@cost_price", costPriceTxt.Text);

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

                clear();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        int status = 1;
        private void filterButton_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            if (status == 1)
            {
                status = 0;
            }
            else status = 1;

            String Menu = "SELECT * FROM menuitem WHERE status = '" + status.ToString() + "' && type = '1'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            menuGridView.DataSource = dt;
            menuGridView.ClearSelection();
        }
        private void clear()
        {
            itemNameTxt.Clear();
            priceTxt.Clear();
            costPriceTxt.Clear();
            createButton.Enabled = true;
            updateButton.Enabled = false;
            menuGridView.ClearSelection();
        }

        private void menuSearch_TextChanged(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            using (MySqlConnection conn = db.connect())
            {
                if (String.IsNullOrWhiteSpace(menuSearch.Text))
                {
                    conn.Open();
                    string query = ("SELECT * FROM menuitem WHERE status = '" + status.ToString() + "'");
                    MySqlDataAdapter testing1 = new MySqlDataAdapter(query, conn);
                    DataTable testing2 = new DataTable();
                    testing1.Fill(testing2);
                    menuGridView.DataSource = testing2;
                }
                else
                {
                    conn.Open();
                    string query = ("SELECT * FROM menuitem WHERE status = '" + status.ToString() + "' AND name LIKE '" + menuSearch.Text + "%'");
                    MySqlDataAdapter testing1 = new MySqlDataAdapter(query, conn);
                    DataTable testing2 = new DataTable();
                    testing1.Fill(testing2);
                    menuGridView.DataSource = testing2;
                }
                menuGridView.ClearSelection();
            }
        }
    }
}

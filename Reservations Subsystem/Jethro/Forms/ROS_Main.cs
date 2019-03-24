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
        int quantity;
        float totalPrice = 0.00f;
        public int DSR_ID;

        #region FORMS
        public ROS_Main()
        {
            InitializeComponent();
        }
        private void ROS_Main_Load(object sender, EventArgs e)
        {
            refreshMenu();
            menuGridView.ClearSelection();
            menuGridView.Columns[0].Visible = false;
            menuGridView.Columns[3].Visible = false;
            amountLabel.Text = "P" + totalPrice.ToString("0.00");
            orderGridView.ClearSelection();
        }
        private void ROS_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Redirect to Main Menu
        }
        #endregion

        #region NAVIGATION
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
        #endregion

        #region ADDING MENU ITEMS INTO CURRENT ORDER
        //ADDING MENU ITEMS INTO CURRENT ORDER
        private void menuGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addButton.Enabled = true;
            removeButton.Enabled = false;
            orderGridView.ClearSelection();
        }
        private void menuGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addItem();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            addItem();
        }
        private void addItem()
        {
            quantity = 1;
            string itemName = menuGridView.SelectedRows[0].Cells[1].Value + string.Empty;
            decimal price = decimal.Parse(menuGridView.SelectedRows[0].Cells[2].Value.ToString());

            Boolean found = false;
            foreach (DataGridViewRow row in menuGridView.SelectedRows)
            {
                foreach (DataGridViewRow row2 in orderGridView.Rows)
                {
                    if (row2.Cells[0].Value.Equals(itemName))
                    {
                        quantity = Int32.Parse(row2.Cells[2].Value.ToString()) + 1;
                        row2.Cells[2].Value = quantity;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    orderGridView.Rows.Add(itemName, price, quantity);
                }
                totalPrice += float.Parse(row.Cells[2].Value.ToString());
                amountLabel.Text = "P" + totalPrice.ToString("0.00");
            }
            orderGridView.ClearSelection();
        }
        #endregion

        #region REMOVING MENU ITEMS FROM CURRENT ORDER
        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeButton.Enabled = true;
            addButton.Enabled = false;
            menuGridView.ClearSelection();
        }
        private void orderGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removeItem();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            removeItem();
        }
        private void removeItem()
        {
            foreach (DataGridViewRow row in orderGridView.SelectedRows)
            {
                quantity = Int32.Parse(row.Cells[2].Value.ToString());
                if (quantity > 1)
                {
                    quantity--;
                    row.Cells[2].Value = quantity;
                }else orderGridView.Rows.RemoveAt(row.Index);
                totalPrice -= float.Parse(row.Cells[1].Value.ToString());
                amountLabel.Text = "P" + totalPrice.ToString("0.00");
            }
        }
        #endregion

        #region INSERTS ORDER INTO DATABASE
        private void createButton_Click(object sender, EventArgs e)
        {
            if (orderGridView.Rows.Count <= 0)
            {
                MessageBox.Show("There are no orders to be made.");
            }else
            {
                try
                {
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    MySqlCommand comm = new MySqlCommand("SELECT id, reportDate FROM dailysalesreport WHERE reportDate = CURDATE()", con);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    //CREATES SALES REPORT FOR THE DAY IF DOES NOT EXISTS YET
                    if (dt.Rows.Count == 0)
                    {
                        con.Open();
                        MessageBox.Show("Sales Report for the day has been created!");
                        MySqlCommand comm2 = new MySqlCommand("INSERT INTO dailysalesreport (reportDate) VALUES (NOW())", con);
                        comm2.ExecuteNonQuery();
                        adp.Fill(dt);
                        con.Close();
                        DSR_ID = Int32.Parse(dt.Rows[0]["id"].ToString());
                    }
                    else
                    {
                        //GRABS THE ID OF CURRENT DSR
                        DSR_ID = Int32.Parse(dt.Rows[0]["id"].ToString());
                    }

                    //INSERTS ORDER RECEIPTS INTO CURRENT DSR
                    con.Open();
                    MySqlCommand comm3 = new MySqlCommand("INSERT INTO order_receipt (dailysalesreport_id, orderTime, totalPrice) " +
                                                          "VALUES (" + DSR_ID + ", CURRENT_TIME()," + totalPrice + ")", con);
                    comm3.ExecuteNonQuery();

                    //SELECTS BOTH THE ID'S OF ORDER_RECEIPTS AND MENUITEM
                    comm = new MySqlCommand("SELECT id FROM order_receipt ORDER BY id DESC", con);
                    adp = new MySqlDataAdapter(comm);
                    DataTable dt2 = new DataTable();
                    adp.Fill(dt2);

                    //GRABS THE ID'S OF CURRENT ORDER RECEIPT AND MENUITEMS
                    int orderID = Int32.Parse(dt2.Rows[0]["id"].ToString());

                    MySqlCommand command1;
                    MySqlCommand comm4;
                    int menuitemID;

                    foreach (DataGridViewRow row in orderGridView.Rows)
                    {
                        command1 = new MySqlCommand("SELECT id FROM menuitem WHERE name = '" + row.Cells[0].Value.ToString() + "'", con);
                        adp = new MySqlDataAdapter(command1);
                        DataTable dt3 = new DataTable();
                        adp.Fill(dt3);
                        menuitemID = Int32.Parse(dt3.Rows[0]["id"].ToString());
                        comm4 = new MySqlCommand("INSERT INTO order_menuitem (order_id, menuitem_id, quantity) " +
                                                          "VALUES (" + orderID + "," + menuitemID + "," + Int32.Parse(row.Cells[2].Value.ToString()) + ")", con);
                        comm4.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                MessageBox.Show("Transaction has been recorded!");
                orderGridView.Rows.Clear();
            }
        }
        #endregion

        #region CLEARS THE ORDER GRID VIEW
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
            } while (orderGridView.Rows.Count > 0);
            totalPrice = 0.00f;
            amountLabel.Text = "P" + totalPrice.ToString("0.00");
        }
        #endregion

        #region MENU QUERY OR SUMTHIN IDK
        public void refreshMenu()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM menuitem";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            menuGridView.DataSource = dt;
        }
        #endregion

        #region SEARCH
        private void menuSearch_TextChanged(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();
            using (MySqlConnection conn = db.connect())
            {
                if (String.IsNullOrWhiteSpace(menuSearch.Text))
                {
                    conn.Open();
                    string query = ("SELECT * FROM menuitem");
                    MySqlDataAdapter testing1 = new MySqlDataAdapter(query, conn);
                    DataTable testing2 = new DataTable();
                    testing1.Fill(testing2);
                    menuGridView.DataSource = testing2;
                }
                else
                {
                    conn.Open();
                    string query = ("SELECT * FROM menuitem WHERE name LIKE '" + menuSearch.Text + "%'");
                    MySqlDataAdapter testing1 = new MySqlDataAdapter(query, conn);
                    DataTable testing2 = new DataTable();
                    testing1.Fill(testing2);
                    menuGridView.DataSource = testing2;
                }
                menuGridView.ClearSelection();
                addButton.Enabled = false;
            }
        }
        #endregion
    }
}

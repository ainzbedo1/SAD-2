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
    public partial class UMS_Roles : Form
    {
        public UMS_Accounts reference { get; set; }
        public UMS_Roles()
        {
            InitializeComponent();
        }

        private void UMS_Roles_Load(object sender, EventArgs e)
        {
            refreshRoles();
        }
        private void refreshRoles()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT * FROM roles";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);
            da.Fill(dt);
            rolesGridView.DataSource = dt;
        }

        private void UMS_Roles_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (roleTitle.Text != "" )
                {
                    String query1 = "INSERT INTO roles (title, inventoryAccess, reservationAccess, posAccess, menuAccess, userAccess) " +
                                    "VALUES ('" + roleTitle.Text + "'," + inv.Checked + "," + res.Checked + "," + 
                                                  pos.Checked + "," + menu.Checked + "," + user.Checked + ")";
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    con.Open();
                    MySqlCommand com = new MySqlCommand(query1, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    refreshRoles();
                    MessageBox.Show("Role has been added!");
                }
                else MessageBox.Show("Please assign Role Title.");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                MessageBox.Show("Title already exists!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idText.Text = rolesGridView.SelectedRows[0].Cells[0].Value.ToString();
            roleTitle.Text = rolesGridView.SelectedRows[0].Cells[1].Value.ToString();
            inv.Checked = bool.Parse(rolesGridView.SelectedRows[0].Cells[2].Value.ToString());
            res.Checked = bool.Parse(rolesGridView.SelectedRows[0].Cells[3].Value.ToString());
            pos.Checked = bool.Parse(rolesGridView.SelectedRows[0].Cells[4].Value.ToString());
            menu.Checked = bool.Parse(rolesGridView.SelectedRows[0].Cells[5].Value.ToString());
            user.Checked = bool.Parse(rolesGridView.SelectedRows[0].Cells[6].Value.ToString());

            editing();
        }
        private void editing()
        {
            updateButton.Enabled = true;
            createButton.Enabled = false;

        }
        private void clear()
        {
            createButton.Enabled = true;
            updateButton.Enabled = false;
            roleTitle.Clear();
            inv.Checked = false;
            res.Checked = false;
            pos.Checked = false;
            menu.Checked = false;
            user.Checked = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (roleTitle.Text != "")
                {
                    String query1 = ("UPDATE roles SET title = @title, " +
                                     "inventoryAccess = @inventoryAccess, " +
                                     "reservationAccess = @reservationAccess, " +
                                     "posAccess = @posAccess, " +
                                     "menuAccess = @menuAccess, " +
                                     "userAccess = @userAccess " +
                                     "WHERE id = " + Int32.Parse(idText.Text));
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@title", roleTitle.Text);
                        cmd.Parameters.AddWithValue("@inventoryAccess", inv.Checked);
                        cmd.Parameters.AddWithValue("@reservationAccess", res.Checked);
                        cmd.Parameters.AddWithValue("@posAccess", pos.Checked);
                        cmd.Parameters.AddWithValue("@menuAccess", menu.Checked);
                        cmd.Parameters.AddWithValue("@userAccess", user.Checked);
                        cmd.Parameters.AddWithValue("@roles_id", res.Checked);

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
                    refreshRoles();

                    clear();
                }
                else MessageBox.Show("Please assign the Role Title.");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void inv_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

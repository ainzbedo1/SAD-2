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
    public partial class UMS_Accounts : Form
    {
        public main_form reference { get; set; }
        public int roles_id;
        public UMS_Accounts()
        {
            InitializeComponent();
        }

        private void UMS_Accounts_Load(object sender, EventArgs e)
        {
            refreshAccounts();

            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT title FROM roles ORDER BY id";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                role.Items.Add("");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    role.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }
        private void refreshAccounts()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT user.id, username, password, firstname, lastname, roles.title, roles_id FROM user JOIN roles ON user.roles_id=roles.id ORDER BY user.id";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            accountsGridView.DataSource = dt;
        }

        private void UMS_Accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            idText.Text = accountsGridView.SelectedRows[0].Cells[0].Value.ToString();
            firstNameTxt.Text = accountsGridView.SelectedRows[0].Cells[1].Value.ToString();
            lastNameTxt.Text = accountsGridView.SelectedRows[0].Cells[2].Value.ToString();
            usernameTxt.Text = accountsGridView.SelectedRows[0].Cells[3].Value.ToString();
            passwordText.Text = accountsGridView.SelectedRows[0].Cells[4].Value.ToString();
            role.SelectedIndex = role.Items.IndexOf(accountsGridView.SelectedRows[0].Cells[5].Value.ToString());

            editing();
        }
        private void editing()
        {
            updateButton.Enabled = true;
            createButton.Enabled = false;
        }
        private void clear()
        {
            updateButton.Enabled = false;
            createButton.Enabled = true;
            idText.Clear();
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            usernameTxt.Clear();
            passwordText.Clear();
            role.SelectedIndex = 0;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNameTxt.Text != "" && lastNameTxt.Text != "" && usernameTxt.Text != "" && passwordText.Text != "" && role.SelectedIndex != 0)
                {
                    String query1 = "INSERT INTO user (username, password, firstname, lastname, roles_id) VALUES ('" + usernameTxt.Text + "','" + passwordText.Text + "','" + firstNameTxt.Text + "','" + lastNameTxt.Text + "'," + roles_id + ")";
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    con.Open();
                    MySqlCommand com = new MySqlCommand(query1, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    refreshAccounts();
                    MessageBox.Show("User has been added!");
                }
                else MessageBox.Show("Please fill in the required fields.");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                MessageBox.Show("Username already exists!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNameTxt.Text != "" && lastNameTxt.Text != "" && usernameTxt.Text != "" && passwordText.Text != "" && role.SelectedIndex != 0)
                {
                    String query1 = ("UPDATE user SET username = @username, password = @password, firstname = @firstname, lastname = @lastname, roles_id = @roles_id WHERE id = " + Int32.Parse(idText.Text));
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                        cmd.Parameters.AddWithValue("@password", passwordText.Text);
                        cmd.Parameters.AddWithValue("@firstname", firstNameTxt.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastNameTxt.Text);
                        cmd.Parameters.AddWithValue("@roles_id", roles_id);

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
                    refreshAccounts();

                    clear();
                }
                else MessageBox.Show("Please fill in the required fields.");
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (role.SelectedIndex != 0)
                {
                    DBConnect db = new DBConnect();
                    MySqlConnection con = db.connect();
                    String Menu = "SELECT roles_id, roles.title FROM user JOIN roles ON user.roles_id=roles.id WHERE roles.title = '" + role.Text + "'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        roles_id = Int32.Parse(dt.Rows[0][0].ToString());
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void editRolesButton_Click(object sender, EventArgs e)
        {
            UMS_Roles umsroles = new UMS_Roles();
            umsroles.reference = this;
            umsroles.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

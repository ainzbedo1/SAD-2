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
    public partial class Inventorymgt : Form
    {
        public main_form reference { get; set; }
        public MySqlConnection dbconnection;
        dbconnector connect = new dbconnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        public string quantity;
        public static string inventoryid;


        public Inventorymgt()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        }

        public void readdata()
        {
            using (MySqlConnection conn = connect.connector())
            {
                string query = "SELECT NAME, IDMINVENTORY, QUANTITY FROM MENUITEM, MINVENTORY WHERE ID = PRODUCT_ID";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                datagridview_inventory.DataSource = dt;
   
            }
            datagridview_inventory.Columns["idmInventory"].Visible = false;
            datagridview_inventory.Columns["name"].HeaderText = "Item Name";
            datagridview_inventory.Columns["quantity"].HeaderText = "Quantity";
        }

       

        private void updateinventory()
        {
            var dbconnect = new dbconnector();
            using (dbconnection = dbconnect.connector())
            {
                using (var command = new MySqlCommand("UPDATE minventory SET quantity = @quantity WHERE idmInventory = @ayd;", dbconnection))
                {
                    dbconnection.Open();
                    command.Parameters.AddWithValue("@quantity", quantityadd());
                    command.Parameters.AddWithValue("@ayd", inventoryid);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void stockout()
        {
            var dbconnect = new dbconnector();
            using (dbconnection = dbconnect.connector())
            {

                dbconnection.Open();
                using (var com = new MySqlCommand("INSERT INTO mstkout(idmInventory, quantity, stockout_date) VALUES(@inventoryid, @quantity, @date)", dbconnection))
                {
                    com.Parameters.AddWithValue("@inventoryid", inventoryid);
                    com.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    com.Parameters.AddWithValue("@quantity", textBox2.Text);

                    com.ExecuteNonQuery();
                }
            }
        }

        private Int32 quantityadd()
        {
            var a = 0;
            if (Convert.ToInt32(quantity) >= 0)
            {
                a = Convert.ToInt32(quantity) - Convert.ToInt32(textBox2.Text);
                return a;
            }
            else
            {
                return -1;
            }
        }

        public orderlistmgt frmol;
        private void btn_orderlistmgt_Click(object sender, EventArgs e)
        {
            frmol = new orderlistmgt();
            //frmol.reference = this;
            frmol.ShowDialog();
        }

        public stockinmgt frmsinout;
        private void btn_stockin_Click(object sender, EventArgs e)
        {
            frmsinout = new stockinmgt();
            //frmsinout.reference = this;
            frmsinout.ShowDialog();
            readdata();
        }

        public itemmgt frmim;
        private void btn_items_Click(object sender, EventArgs e)
        {
            frmim = new itemmgt();
            //frmim.reference = this;
            frmim.ShowDialog();
        }
        
        private void Inventorymgt_Load(object sender, EventArgs e)
        {
            readdata();
            datagridview_inventory.ClearSelection();
        }

        private void btn_stockout_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text != "0")
            {
                
                    if (quantityadd() >= 0)
                    {
                        DialogResult res = MessageBox.Show("CONFIRM STOCK-OUT OF ITEMS?", "CONFIRM!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            updateinventory();
                            stockout();
                            
                            textBox2.Clear();
                            datagridview_inventory.ClearSelection();
                            btn_stockoutlist.Enabled = false;
                            MessageBox.Show("SUCCESSFULLY STOCKED-OUT QUANTITY OF ITEMS!", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            readdata();
                    }
                    }
                else
                {
                    MessageBox.Show("A STOCK-OUT TYPE SHOULD BE SELECTED", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("QUANTITY MUST NOT BE LEFT EMPTY, OR SET TO ZERO", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public stockoutlist stklist;
        private void btn_stockoutlist_Click(object sender, EventArgs e)
        {
            stklist = new stockoutlist();
            //stklist.reference = this;
            stklist.Show();
        }

        private void datagridview_inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                btn_stockoutlist.Enabled = true;
                textBox2.Enabled = true;
                inventoryid = datagridview_inventory.Rows[e.RowIndex].Cells["idmInventory"].Value.ToString();
                quantity = datagridview_inventory.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventorymgt_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
    }
    
}
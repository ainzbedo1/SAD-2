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

namespace Hotel_Inventory
{
    public partial class stockoutlist : Form
    {
        public MySqlConnection dbconnection;
        // public FormInventory reference { get; set; }
        dbconnector connect = new dbconnector();
        MySqlDataAdapter adapter;
        DataTable dt;

        public string invid;
        public stockoutlist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockoutlist_Load(object sender, EventArgs e)
        {
            readdata();
            datagridview_stockout.ClearSelection();
        }

        public void readdata()
        {
            using (MySqlConnection conn = connect.connector())
            {
                //string query = "SELECT idmInventory, mInventorycol, stock_in_date, product_id, stock_out_date, quantity, status FROM minventory, menu_item WHERE minventory.status = 1 and menu_item.id = '" + Inventorymgt.inventoryid +"'";
                string query = "select * from mstkout";
                dt = new DataTable();
                adapter = new MySqlDataAdapter(query, conn);
                adapter.Fill(dt);
                datagridview_stockout.DataSource = dt;

                datagridview_stockout.Columns["idmstkout"].Visible = false;
                datagridview_stockout.Columns["idmInventory"].Visible = false;
               datagridview_stockout.Columns["stockout_date"].HeaderText = "Stock Out Date";
                datagridview_stockout.Columns["quantity"].HeaderText = "Quantity";
                datagridview_stockout.Columns["mstkoutcol"].Visible = false;

            }
        }
    }
}

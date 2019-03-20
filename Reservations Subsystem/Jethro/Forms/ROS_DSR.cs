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
    public partial class ROS_DSR : Form
    {
        public ROS_Main reference { get; set; }
        public ROS_DSR()
        {
            InitializeComponent();
        }
        private void ROS_DSR_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String dsr_id;
        public String order_id;
        
        private void ROS_DSR_Load(object sender, EventArgs e)
        {
            loadDSR();
            DSRGridView.Columns[0].Visible = false;
            DSRGridView.ClearSelection();
        }
        //LEFT PANEL
        private void DSRGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dsr_id = DSRGridView.SelectedCells[0].Value.ToString();
            loadOrderReceipts();
            orderReceiptsGridView.ClearSelection();
            orderReceiptsGridView.Columns[0].Visible = false;
            ordersGridView.Columns.Clear();
        }
        //MIDDLE PANEL
        private void orderReceiptsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            order_id = orderReceiptsGridView.SelectedCells[0].Value.ToString();
            loadOrders();
            ordersGridView.ClearSelection();
        }
        
        public void loadDSR()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT id, reportDate, revenue FROM dailysalesreport";
            //String Menu = "SELECT * FROM dailysalesreport";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            DSRGridView.DataSource = dt;
        }
        public void loadOrderReceipts()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT id, orderTime, totalPrice FROM order_receipt WHERE dailysalesreport_id = " + dsr_id;
            //String Menu = "SELECT * FROM order_receipt WHERE dailysalesreport_id = 1";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            orderReceiptsGridView.DataSource = dt;
        }
        public void loadOrders()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            //String Menu = "SELECT orderTime, totalPrice FROM order_receipt WHERE dailysalesreport_id = 1";
            String Menu = "SELECT menuitem.name, menuitem.price FROM order_menuitem JOIN menuitem ON order_menuitem.menuitem_id = menuitem.id WHERE order_menuitem.order_id = " + order_id;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            ordersGridView.DataSource = dt;
        }
    }
}

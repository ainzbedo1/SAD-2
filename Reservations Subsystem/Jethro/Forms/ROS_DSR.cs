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

            loadAllOrders();
            ordersGridView.ClearSelection();
            ordersGridView.Sort(ordersGridView.Columns["Quantity"], ListSortDirection.Descending);
        }
        //MIDDLE PANEL
        private void orderReceiptsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            order_id = orderReceiptsGridView.SelectedCells[0].Value.ToString();
            loadOrders();
            ordersGridView.ClearSelection();
            ordersGridView.Sort(ordersGridView.Columns["Quantity"], ListSortDirection.Descending);
        }
        
        public void loadDSR()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT id, reportDate as Date, revenue as Revenue FROM dailysalesreport ORDER BY reportDate DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            DSRGridView.DataSource = dt;
        }
        public void loadOrderReceipts()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT id, orderTime as Time, totalPrice as Payment FROM order_receipt WHERE dailysalesreport_id = " + dsr_id + " ORDER BY id DESC";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            orderReceiptsGridView.DataSource = dt;
        }
        public void loadAllOrders()
        {
            
            try
            {
                DBConnect db = new DBConnect();
                MySqlConnection con = db.connect();
                String Menu = "SELECT menuitem.name, order_menuitem.quantity FROM dailysalesreport JOIN order_receipt ON order_receipt.dailysalesreport_id = dailysalesreport.id JOIN order_menuitem ON order_menuitem.order_id = order_receipt.id JOIN menuitem ON order_menuitem.menuitem_id = menuitem.id WHERE dailysalesreport.id = " + dsr_id + "  ORDER BY menuitem.name";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

                da.Fill(dt);
                string[] array1 = new string[dt.Rows.Count]; //idk
                int[] array2 = new int[] { }; //quantity
                int sumthin, counter = 0;
                if (dt.Rows.Count > 0)
                {

                    //GETS UNIQUE NAMES
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!array1.Contains(dt.Rows[i][0].ToString()))
                        {
                            array1[counter] = dt.Rows[i][0].ToString();
                            //MessageBox.Show(array1[counter].ToString());
                            counter++;
                        }
                    }
                    array2 = new int[array1.Length];
                    //FILL 0
                    for (int a = 0; a < array1.Length; a++)
                    {
                        array2[a] = 0;
                    }
                    //CALCULATES QUANTITY
                    for (int j = 0; j < array1.Length; j++)
                    {
                        sumthin = Array.IndexOf(array1, dt.Rows[j][0].ToString());
                        array2[sumthin] = array2[sumthin] + Int32.Parse(dt.Rows[j][1].ToString());
                    }
                    DataTable dt2 = new DataTable();
                    DataRow dr;
                    dt2.Columns.Add("Name");
                    dt2.Columns.Add("Quantity");
                    dr = dt2.NewRow();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (array2[i] != 0)
                        {
                            dr["Name"] = array1[i];
                            dr["Quantity"] = array2[i];
                            dt2.Rows.Add(dr);
                            dr = dt2.NewRow();
                        }
                    }
                    ordersGridView.DataSource = dt2;

                }
            }catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void loadOrders()
        {
            DBConnect db = new DBConnect();
            MySqlConnection con = db.connect();
            String Menu = "SELECT menuitem.name, order_menuitem.quantity FROM order_menuitem JOIN menuitem ON order_menuitem.menuitem_id = menuitem.id WHERE order_menuitem.order_id = " + order_id + " ORDER BY menuitem.name";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(Menu, con);

            da.Fill(dt);
            ordersGridView.DataSource = dt;
        }
    }
}

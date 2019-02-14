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
    public partial class ViewRoom : Form
    {
        public ReservationCalendarForm referencefrm1 { get; set; }
        public MySqlConnection conn;
        public ViewRoom()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
            
        }
        

        private void AddRoomView_Load(object sender, EventArgs e)
        {
            DisplayRoom();
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            datagridViewRoom.ClearSelection();
            datagridViewRoom.CurrentCell = null;
        }
        public void refreshData()
        {
            datagridViewRoom.Refresh();
        }
        private void DisplayRoom()
        {
            DataRow dr;
            DataTable dt = new DataTable();
           
            string strSql = "select * from room";
            using (MySqlDataAdapter dadapter = new MySqlDataAdapter(strSql, conn))
            {
                DataTable table = new DataTable();
                dadapter.Fill(table);
                this.datagridViewRoom.DataSource = table;
            }
            datagridViewRoom.Columns[0].Visible = false;

            datagridViewRoom.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.referenceViewRoomList = this;
            addRoom.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            referencefrm1.Show();
            
        }

        private void room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void ViewRoom_Shown(object sender, EventArgs e)
        {
            datagridViewRoom.ClearSelection();
            datagridViewRoom.Refresh();

        }
        public void refreshing()
        {
            DisplayRoom();
            datagridViewRoom.ClearSelection();
            datagridViewRoom.Refresh();

        }

        private void ViewRoom_Activated(object sender, EventArgs e)
        {
            this.Refresh();
            this.refreshing();
        }
    }
}

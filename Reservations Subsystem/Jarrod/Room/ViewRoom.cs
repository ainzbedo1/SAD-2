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
        public int roomId {get; set;}
        public ViewRoom()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
            
        }
        public int RoomId
        {
            set { roomId = value; }
            get { return roomId; }
        }

        


        public void refreshData()
        {
            dgvRoom.Refresh();
        }
        private void DisplayRoom()
        {
            
            DataTable dt = new DataTable();
           
            string strSql = "select * from room";
            using (MySqlDataAdapter dadapter = new MySqlDataAdapter(strSql, conn))
            {
                DataTable table = new DataTable();
                dadapter.Fill(table);
                this.dgvRoom.DataSource = table;
            }
            dgvRoom.Columns[0].Visible = false;

            dgvRoom.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            AddRoom addRoom = new AddRoom();
            RoomDataService roomData = new RoomDataService();
            RoomInfo myRoomInfo = new RoomInfo();

            myRoomInfo = roomData.getRoomInfoById(RoomId);
            addRoom.EditForm = true;
            addRoom.SettingRoomInfo(myRoomInfo);
            addRoom.referenceViewRoomList = this;
            addRoom.Show();
            this.Hide();
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
            this.Close();
            //this.Hide();
            referencefrm1.Refresh();
            referencefrm1.Show();

            
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dgvRoom.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                try
                {
                    RoomId = dgvRoom.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("selecting from datagridview failed " + ex.ToString());
                }

            }
            */
        }

        private void ViewRoom_Shown(object sender, EventArgs e)
        {
            dgvRoom.ClearSelection();
            dgvRoom.Refresh();

        }
        public void refreshing()
        {
            DisplayRoom();
            dgvRoom.ClearSelection();
            dgvRoom.Refresh();

        }

        private void ViewRoom_Activated(object sender, EventArgs e)
        {
            this.Refresh();
            this.refreshing();
        }
        public void DisableButtons()
        {
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
        }
        private void ViewRoom_Load(object sender, EventArgs e)
        {
            dgvRoom.ClearSelection();
            DisplayRoom();
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;
            dgvRoom.ClearSelection();
            dgvRoom.CurrentCell = null;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;

        }
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                try
                {
                    RoomId = Convert.ToInt32(dgvRoom.SelectedRows[0].Cells[0].Value);
                    btnEdit.Enabled = true;
                    btnRemove.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("selecting from datagridview failed " + ex.ToString());
                }

            }

        }
    }
}

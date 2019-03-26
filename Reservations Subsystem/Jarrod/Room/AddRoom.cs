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
using System.Windows.Documents;

namespace Reservations_Subsystem
{
    public partial class AddRoom : Form
    {
        //public ViewRoom referenceViewRoom { get; set; }
        public MySqlConnection conn;
        public ViewRoom referenceViewRoomList { get; set; }
        public Boolean EditForm;
        public int id { get; set; }
        public RoomInfo theRoomInfo { get; set; }
        // public Room roomForm;
        private int roomTypeId { get; set; }
        public int RoomTypeId
        {
            set { roomTypeId = value; }
            get { return roomTypeId; }
        }
        public RoomInfo TheRoomInfo
        {
            set { theRoomInfo = value; }
            get { return theRoomInfo; }
        }
        public AddRoom()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SettingRoomInfo(RoomInfo room)
        {
            txtRoomNumber.Text = room.RoomNumber;
            cmbRoomType.SelectedText = room.RoomType;
            cmbFloor.SelectedValue = room.FloorLevel;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckingFields() == false)
            {
                RoomDataService testRoom = new RoomDataService();
                testRoom.AddRoom(txtRoomNumber.Text, RoomTypeId, cmbFloor.Text, txtDesc.Text);
                referenceViewRoomList.Refresh();

                referenceViewRoomList.refreshing();
                referenceViewRoomList.DisableButtons();
                referenceViewRoomList.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There are missing fields please fill them up");
            }
        }

        private void LoadRoomTypeCombo()
        {
            //get combo box items
            // filter by type
            //ComboBox hello = elementHOs   
            List<string> myRooms = new List<string>();

            RoomDataService myRoomDataService = new RoomDataService();
            myRooms = myRoomDataService.getRoomTypes();
            foreach (var item in myRooms)
            {
                cmbRoomType.Items.Add(item);
            }
            //RoomDataService 

        }


        public Boolean CheckingFields()
        {
            Boolean nullFields = false;
            if (String.IsNullOrEmpty(txtRoomNumber.Text))
            {             
                nullFields = true;
            }
            if (String.IsNullOrEmpty(cmbFloor.Text))
            {
                nullFields = true;
            }
            if (String.IsNullOrEmpty(cmbRoomType.Text))
            {
                nullFields = true;
            }
            return nullFields;
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            MessageBox.Show(id.ToString());
            //referenceViewRoomList.Show();
            //this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            referenceViewRoomList.Show();
            
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRoom_Activated(object sender, EventArgs e)
        {
            referenceViewRoomList.Refresh();
        }

        private void txtRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

            RoomDataService myRoomDataService = new RoomDataService();
            RoomTypeInfo myRoomTypeInfo = new RoomTypeInfo();
            myRoomTypeInfo = myRoomDataService.getRoomTypeByName(cmbRoomType.Text);
            RoomTypeId = myRoomTypeInfo.TypeId;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            referenceViewRoomList.Show();
        }
    }
}

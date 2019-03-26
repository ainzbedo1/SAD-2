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
    public partial class EditRoom : Form
    {
        public ViewRoom referenceViewRoomList { get; set; }
        public MySqlConnection conn;
        private int roomId { get; set; }
        public string holdValue { get; set; }
        public string roomTypeId { get; set; }
        private int roomTypeIdCombo { get; set; }
        public int RoomTypeIdCombo
        {
            set { roomTypeIdCombo = value; }
            get { return roomTypeIdCombo; }
        }

        public int RoomId
        {
            get { return roomId; }
            set {  roomId = value; }

        }
        public EditRoom()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");

        }
        public void SettingRoomInfo(RoomInfo room)
        {
            txtRoomNumber.Text = room.RoomNumber;
            cmbRoomType.SelectedText = room.RoomType;
            cmbFloor.SelectedValue = room.FloorLevel;
        }
        public void initializeData()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM room WHERE id =" + roomId, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    txtRoomNumber.Text = dt.Rows[0]["roomNumber"].ToString();
                    roomTypeId = dt.Rows[0]["roomTypeId"].ToString();
                    cmbFloor.Text = dt.Rows[0]["floorLevel"].ToString();
                    txtDesc.Text = dt.Rows[0]["description"].ToString();


                }

                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Nah!" + ee);
                conn.Close();
            }
            RoomDataService myRoomDataServ = new RoomDataService();
            
            RoomTypeInfo lesbian = new RoomTypeInfo();
            MessageBox.Show(roomTypeId.ToString());
            //string why =
            lesbian = myRoomDataServ.getRoomTypeByInt(Convert.ToInt32(roomTypeId));
            MessageBox.Show(lesbian.TypeName);
            cmbRoomType.Text = lesbian.TypeName;
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            initializeData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("UPDATE room SET roomNumber ='" + txtRoomNumber.Text + "', roomTypeId ='" + RoomTypeIdCombo + "', floorLevel ='" + cmbFloor.Text + "', description ='" + txtDesc.Text +  "' WHERE id = '" + RoomId + "';", conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                conn.Close();
            }
            this.Close();
            referenceViewRoomList.Show();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDataService myRoomDataService = new RoomDataService();
            RoomTypeInfo myRoomTypeInfo = new RoomTypeInfo();
            myRoomTypeInfo = myRoomDataService.getRoomTypeByName(cmbRoomType.Text);
            RoomTypeIdCombo = myRoomTypeInfo.TypeId;
        }
    }
}

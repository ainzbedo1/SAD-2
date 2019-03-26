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
    public partial class AddRoomRate : Form
    {
        public AddReservationView referencefrm1 { get; set; }
        private int typeId { get; set; }
        public int TypeId
        {
            set { typeId = value; }
            get { return typeId; }
        }
        public AddRoomRate()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void CheckingFields()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RoomDataService testRoom = new RoomDataService();
            testRoom.AddRoomRate(TypeId, txtRoomRate.Text);
            referencefrm1.LoadComboRoomRates();
            this.Close();
        }

        private void AddRoomRate_Load(object sender, EventArgs e)
        {
            LoadRoomTypeCombo();
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
                cmbRoomTypes.Items.Add(item);
            }
            //RoomDataService 

        }

        private void cmbRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDataService myRoomDataService = new RoomDataService();
            RoomTypeInfo myRoomTypeInfo = new RoomTypeInfo();
            myRoomTypeInfo = myRoomDataService.getRoomTypeByName(cmbRoomTypes.Text);
            TypeId = myRoomTypeInfo.TypeId;

        }

        private void cmbRoomTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddRoomRate_FormClosing(object sender, FormClosingEventArgs e)
        {
            referencefrm1.Show();
        }
    }
}

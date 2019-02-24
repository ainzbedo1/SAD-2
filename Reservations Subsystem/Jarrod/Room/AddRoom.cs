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
        public ViewRoom referenceViewRoomList {get; set;}
       // public Room roomForm;
        public AddRoom()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {

            Room testRoom = new Room();
            testRoom.AddRoom(txtRoomNumber.Text, cmbRoomType.Text, cmbFloor.Text, txtDesc.Text);
            referenceViewRoomList.Refresh();
            referenceViewRoomList.refreshing();
            referenceViewRoomList.Show();
            this.Hide();

            
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
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
    }
}

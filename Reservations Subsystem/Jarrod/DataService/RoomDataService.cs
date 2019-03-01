using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Reservations_Subsystem
{
    public class RoomDataService
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        // Get roomInfo by room number
        public RoomInfo getRoomInfoByRoomNumber(string roomNumber)
        {
            string query = "SELECT id, roomNumber, roomType, description, occupied FROM room WHERE roomNumber = '" + roomNumber + "' ";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                using (myReader = cmd.ExecuteReader())
                {

                    if (myReader.Read())
                    {
                        return new RoomInfo
                        {

                            RoomId = (myReader[0]).ToString(),
                            RoomNumber = myReader[1].ToString(),
                            RoomType = (myReader[2]).ToString()

                        };
                    }


                }
   

            }
            return null;
        }
        public RoomInfo getRoomInfoById(int roomId)
        {
            string query = "SELECT id, roomNumber, roomType, description, occupied FROM room WHERE id = '" + roomId + "' ";
            MySqlConnection.ClearPool(conn);
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                using (myReader = cmd.ExecuteReader())
                {

                    if (myReader.Read())
                    {
                        return new RoomInfo
                        {

                            RoomId = (myReader[0]).ToString(),
                            RoomNumber = myReader[1].ToString(),
                            RoomType = (myReader[2]).ToString()

                        };
                    }
                    MySqlConnection.ClearPool(conn);
                }
                MySqlConnection.ClearPool(conn);

            }
            MySqlConnection.ClearPool(conn);
            return null;
        }
        public List<RoomTextBoxItems> getAllRoomId()
        {
            var myComboItemsList = new List<RoomTextBoxItems>();
            string query = "SELECT id, roomNumber, roomType FROM room";
            using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
            {
                try
                { 

                    DataTable dt = new DataTable();
                    blah.Fill(dt);
                    foreach (DataRow drow in dt.Rows)  
                    {
                        RoomTextBoxItems myComboItems = new RoomTextBoxItems();
                        myComboItems.ID = Convert.ToInt32(drow[0]);
                        myComboItems.RoomNumber = (drow[1]).ToString();
                        myComboItems.RoomType = (drow[2]).ToString();

                        myComboItemsList.Add(myComboItems);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                   // Console.WriteLine(ex);
                }
            }
            MessageBox.Show(myComboItemsList[0].RoomNumber);
            MessageBox.Show(myComboItemsList[1].RoomNumber);
            return myComboItemsList;
        }

    }
}

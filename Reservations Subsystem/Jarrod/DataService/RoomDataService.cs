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

        public List<RoomTextBoxItems> getRoomInfoByType(string roomType)
        {
            var myComboItemsList = new List<RoomTextBoxItems>();
            string query = "SELECT id, roomNumber, roomType FROM room WHERE roomType ='"+roomType+"' ";
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
            return myComboItemsList;
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
            return myComboItemsList;
        }



        //SELECT Distinct roomType FROM sad2_db.room order by roomType;
        public List<string> getRoomTypes()
        {

            var myRoomTypes = new List<string>();
            string query = "SELECT Distinct roomType FROM sad2_db.room order by roomType";
            using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
            {
                try
                {

                    DataTable dt = new DataTable();
                    blah.Fill(dt);
                    foreach (DataRow drow in dt.Rows)
                    {
                        RoomTextBoxItems myComboItems = new RoomTextBoxItems();
                        myRoomTypes.Add(drow[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    // Console.WriteLine(ex);
                }
            }

            return myRoomTypes;
        }
        public int GetAmtRooms()
        {
            DataTable dt = new DataTable();
            int amtOfRooms = 0;
            string query = "SELECT COUNT(roomNumber) FROM room";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        amtOfRooms = Convert.ToInt32(dt.Rows[0][0]);
                        // dt.Columns.Add("TotalReserveDays", typeof(Int32));
                        //dt.Columns.Add("CalcDays", typeof(Int32))



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter get amount of rooms failed");
                    return 0;
                }
            }
            return amtOfRooms;


        }
    }
}

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

            string query = "SELECT id, roomNumber, roomType, description FROM room WHERE roomNumber = '" + roomNumber + "' ";
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
            string query = "SELECT room.id, room.roomNumber, rt.roomType " +
                "FROM sad2_db.room_type rt " +
                "INNER JOIN sad2_db.room room " +
                    "ON rt.id = room.roomTypeId " +
                "WHERE room.id = @roomId";
                /*
            //"SELECT room.roomNumber, rt.roomType FROM sad2_db.room_type rt INNER JOIN sad2_db.room room ON rt.id = room.roomTypeId; "
            string query = "SELECT room.id, room.roomNumber, rt.roomType " +
                "FROM room_type rt " +
                "INNER JOIN room room " +
                    "ON rt.id = room.roomTypeId " +
                "INNER JOIN sad2_db.room_rate rate " +
                    "ON room.id = rate.room_Type_id " +
                "WHERE room.id = @id";
                */
            //string query = "SELECT room, roomNumber, roomType, description FROM room WHERE id = '" + roomId + "' ";
            //MySqlConnection.ClearPool(conn);
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                cmd.Parameters.AddWithValue("@roomId", roomId);

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
            string query = "SELECT id, typeName FROM room WHERE room_type ='"+roomType+"' ";
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
                        myComboItems.roomType = (drow[1]).ToString();

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
        public void AddRoom(string roomNumber, string roomType, string floorLevel, string description)
        {

            string query = "INSERT INTO room(roomNumber, floorLevel, description) VALUES(@roomNumber, @roomType, @floorLevel, @description)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                
                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                //cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@floorLevel", floorLevel);
                cmd.Parameters.AddWithValue("@description", description);
                //cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        
        public void UpdateRoom(string roomNumber, string roomType, string floorLevel, string description)
        {

            string query = "INSERT INTO room(roomNumber, floorLevel, description) VALUES(@roomNumber, @floorLevel, @description)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                //cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@floorLevel", floorLevel);
                cmd.Parameters.AddWithValue("@description", description);
                //cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        /*
        public DataTable AllRoomId()
        {
            string query = "SELECT id, roomNumber, roomType FROM room";
            using(MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    DataTable myTable = new DataTable();
                    myTable 
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
        */

        public void EditRoom(int id, string roomNumber, string roomType, string floorLevel, string description)
        {
            // "UPDATE Inventory SET Inventorynumber='"+ num +"',Inventory_Name='"+name+"', Quantity ='"+ quant+"',Location ='"+ location+"' Category ='"+ category+"' WHERE Inventorynumber ='"+ numquery +"';";
            string query = "UPDATE room SET roomNumber=@roomNumber,roomNumber=@roomNumber, roomType=@roomType ,floorLevel=@floorLevel,description=@description WHERE id =@id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@floorLevel", floorLevel);
                cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

}

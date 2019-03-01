using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    public class Room
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");


        public void AddRoom(string roomNumber, string roomType, string floorLevel, string something)
        {
            string query = "INSERT INTO room VALUES(@roomNumber, @roomType, @floorLevel, @description)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                cmd.Parameters.AddWithValue("@roomType", roomType);
                cmd.Parameters.AddWithValue("@floorLevel", floorLevel);
                cmd.Parameters.AddWithValue("@description", something);
                //cmd.Parameters.AddWithValue("@description", description);
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
        /*
        public MySqlDataAdapter getRoom(int roomNumber)
        {
            string query = "SELECT * FROM room WHERE roomNumber = '" + roomNumber + "' ";
        }
        */
    }
}

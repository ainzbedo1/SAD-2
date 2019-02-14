using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Reservations_Subsystem
{
    class Reservation
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        public void AddReservation(string roomNumber, string roomType, string floorLevel, string something)
        {
            string query = "roomNumber, roomType, floorLevel, description) VALUES(@roomNumber, @roomType, @floorLevel, @description";
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
    }
}

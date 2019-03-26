using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservations_Subsystem
{
    public class TestDataService
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");

        public long AddReservation(int roomId, int customerId, string description, DateTime startDate, DateTime endDate, int occupied, int totalPrice, int lengthOfStay, int rate)
        {

            string query = "INSERT INTO reservation(room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate) VALUES((SELECT id FROM room WHERE id = @room_id), @customer_id, @description, @startDate, @endDate, @occupied, @totalPrice, @lengthOfStay, @rate)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@room_id", roomId);
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@occupied", occupied);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@lengthOfStay", lengthOfStay);
                cmd.Parameters.AddWithValue("@rate", rate);


                //cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    // conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    long idReservation = cmd.LastInsertedId;
                    return idReservation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " the failed Reservation Failed");

                    return 0;

                }

            }
        }
        public void AddReservation2nd(int roomId, int customerId, string description, DateTime startDate, DateTime endDate, int occupied, int totalPrice, int lengthOfStay, int rate)
        {

            string query = "INSERT INTO reservation(room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate) VALUES(@room_id, @customer_id, @description, @startDate, @endDate, @occupied, @totalPrice, @lengthOfStay, @rate)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@room_id", roomId);
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                cmd.Parameters.AddWithValue("@occupied", occupied);
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@lengthOfStay", lengthOfStay);
                cmd.Parameters.AddWithValue("@rate", rate);


                //cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    // conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    long idReservation = cmd.LastInsertedId;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " the failed Reservation Failed");


                }

            }
        }
    }
}

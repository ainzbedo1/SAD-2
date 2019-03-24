using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Reservations_Subsystem
{
    public class RoomInfo
    {
        
        private string roomType { get; set; }
        private string roomNumber { get; set; }
        private string roomId { get; set; }
        private string floorLevel { get; set; }
        private string description { get; set; }
        private string roomRate { get; set; }
        private DateTime dateCreated { get; set; }
        private string singleBesd { get; set; }
        private Boolean occupied { get; set; }

        private string desc { get; set; }
        // private string checkInDate { get; set; }
        // private string checkOutDate { get; set; }



        public string RoomRate
        {
            set { roomRate = value; }
            get { return roomRate; }
        }

        public string RoomId
        {
            set { roomId = value; }
            get { return roomId; }
        }
        public string RoomType
        {
            set { roomType = value; }
            get { return roomType; }
        }
        public string RoomNumber
        {
            set { roomNumber = value; }
            get { return roomNumber; }
        }
        public string Desc
        {
            set { desc = value; }
            get { return desc; }
        }
        public string FloorLevel
        {
            set { floorLevel = value; }
            get { return floorLevel; }
        }
        /*
        public int NumberOfDays
        {
            set { numberOfDays = value; }
            get { return numberOfDays; }
        }
        */

        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        public void AddReservation(int roomId, int customerId, string description, DateTime checkInDate, DateTime checkOutDate, Boolean occupied, int price)
        {
            string query = "INSERT INTO room VALUES(@roomId, @customerId, @description, @checkInDate, @checkOUtDate, @occupied, @price)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@roomID", roomId);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@checkInDate", checkInDate);
                cmd.Parameters.AddWithValue("@checkOUtDate", checkOutDate);
                cmd.Parameters.AddWithValue("@occupied", occupied);
                cmd.Parameters.AddWithValue("@price", occupied);
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Reservations_Subsystem
{
    public class ReservationInfo
    {
       
        public DateTime startDate { get; set; }
        private DateTime endDate { get; set; }
        private string numberOfDays { get; set; }
        private string roomType { get; set; }
        private string roomNumber { get; set; }
        private string roomId { get; set; }
        private int customerId { get; set; }
        private string desc { get; set; }
        private int occupied { get; set; }
        private int lengthOfStay { get; set; }
        private int totalPrice { get; set; }
        // private string checkInDate { get; set; }
        // private string checkOutDate { get; set; }
        private int price { get; set; }
        private int resId { get; set; }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public int ResId
        {
            set { price = value; }
            get { return price; }
        }
        public int TotalPrice
        {
            set { totalPrice = value; }
            get { return totalPrice; }
        }
        public int Occupied
        {
            set { occupied = value; }
            get { return occupied; }
        }
        public int LenghtOfStay
        {
            set { lengthOfStay = value; }
            get { return lengthOfStay; }
        }
        
        public string RoomId
        {
            set { roomId = value; }
            get { return roomId; }
        }
        
        public int CustomerId
        {
            set { customerId = value; }
            get { return customerId; }
        }

        public DateTime StartDate
        {
            set { startDate = value; }
            get { return startDate; }
        }
        public DateTime EndDate
        {
            set { endDate = value; }
            get { return endDate; }

        }
        public string Desc
        {
            set { desc = value; }
            get { return desc; }
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

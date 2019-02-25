using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Reservations_Subsystem
{
    public class ReservationDataService
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");

        public void DeleteReservation(int resId)
        {
            string query = ("DELETE FROM reservation WHERE id = @id");
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                cmd.Parameters.AddWithValue("@id", resId);
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
        

        public ReservationInfo GetReservationInfoById(int resId)
        {
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay FROM reservation id WHERE id = '" + resId + "' ";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                using (myReader = cmd.ExecuteReader())
                {

                    if (myReader.Read())
                    {
                        return new ReservationInfo
                        {
                            ResId = Convert.ToInt32((myReader[0])), 
                            RoomId = (myReader[1]).ToString(),
                            CustomerId = Convert.ToInt32(myReader[2]),
                            Desc = (myReader[3]).ToString(),
                            StartDate = Convert.ToDateTime(myReader[4]),
                            EndDate = Convert.ToDateTime(myReader[5]),
                            Occupied = Convert.ToInt32(myReader[6]),
                            TotalPrice = Convert.ToInt32(myReader[7]),
                            LenghtOfStay = Convert.ToInt32(myReader[8])
                            //Desc = (myReader[2]).ToString(),

                        };
                    }
                }
        

            }
        
            return null;
        }


        public long AddReservation(int roomId, int customerId, string description, DateTime startDate, DateTime endDate, int occupied, int totalPrice, int lengthOfStay)
        {
            string query = "INSERT INTO reservation(room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay) VALUES((SELECT id FROM room WHERE id = @room_id), @customer_id, @description, @startDate, @endDate, @occupied, @totalPrice, @lengthOfStay)";
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
                    Console.WriteLine(ex.Message + "Reservation Failed");

                    return 0;

                }

            }
        }
        public void verifyCustomerInfoAndCreateReservation(CustomerInfo Customer, ReservationInfo ResNow, ReservationCalendarForm calendar) {
            string query = "SELECT COUNT(*) FROM customer WHERE name=@name";
         
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Execute Scalar returns the first column of the first row
                cmd.Parameters.AddWithValue("@name", Customer.Name);
                try
                {
                    conn.Open();
                    int CustomerExists = Convert.ToInt32(cmd.ExecuteScalar());
                    if (CustomerExists > 0)
                    {
                        if (MessageBox.Show("A customer with same name exists already" +
                            "would you like create a new customer with the same name" +
                            "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            // if user clicked yes 
                            
                            
                        }
                        else
                        {
                            // user clicked no
                        }
                    }
                    else
                    {
                        try
                        {
                            CustomerDataService customerData = new CustomerDataService();
                            //insert into customer
                            // insert into statement of account
                            // insert into question reservation form
                            // inesrt into customer
                            // insert into reservation
                            long lastInsertedCustomer = customerData.InsertIntoCustomer(Customer.Name, Customer.Company, Customer.Address, Customer.Phone, Customer.Email, Customer.Passport, Customer.Nationality, Customer.Gender, Customer.BirthDate, Customer.BirthPlace);
                            MessageBox.Show(lastInsertedCustomer.ToString());
                            //public void InsertIntoReservation(int roomId, int customerId, string description, string checkInDate, string checkOutDate, Boolean occupied, string totalPrice, string lengthOfStay)
                            //reserveNow = GetByRoomNumber(Convert.ToString(roomId));
                            ResNow.CustomerId = Convert.ToInt32(lastInsertedCustomer);
                            MessageBox.Show(ResNow.startDate.ToString());
                            long lastInsertReservation = AddReservation(Convert.ToInt32(ResNow.RoomId), ResNow.CustomerId, ResNow.Desc, ResNow.StartDate, ResNow.EndDate, 0, ResNow.TotalPrice, ResNow.LenghtOfStay);

                            //if reseravtion is in range of datagridview 
                            if ((ResNow.StartDate.Year == ResNow.EndDate.Year) && (ResNow.StartDate.Month == ResNow.EndDate.Month))
                            {
          
                                //ReservationCalendarForm calendar = new ReservationCalendarForm();
                                
                                RoomDataService roomDataService = new RoomDataService();
                                RoomInfo selectedRoom = new RoomInfo();


                                selectedRoom = roomDataService.getRoomInfoById(Convert.ToInt32(ResNow.RoomId));
                                string myRoomId = selectedRoom.RoomId;
                                calendar.findFirstcell(ResNow.StartDate, ResNow.EndDate, lastInsertReservation, ResNow.RoomId);
                                //calendar.createb(
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        
                        



                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("not working" + ex);
                }
            }

        }

        //gets reservation that use the same room 
        //and find ifthat arn range of the datagridviews date
        public List<ReservationInfo> FilterReservationByDgvDate(DateTime RangeFrom, DateTime RangeTill)
        {
            List<ReservationInfo> listOfReservation = new List<ReservationInfo>();
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay FROM reservation  WHERE NOT (startDate > @RangeTill OR endDate < @RangeFrom)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RangeTill", RangeTill);
                cmd.Parameters.AddWithValue("@RangeFrom", RangeFrom);
                try
                {
                    MySqlDataReader myReader;
                    conn.Open();
                    using (myReader = cmd.ExecuteReader())
                    {

                        while (myReader.Read())
                        {

                            ReservationInfo resInfo = new ReservationInfo();
                            resInfo.ResId = Convert.ToInt32((myReader[0]));
                            resInfo.RoomId = (myReader[1]).ToString();
                            resInfo.CustomerId = Convert.ToInt32(myReader[2]);
                            resInfo.Desc = (myReader[3]).ToString();
                            resInfo.StartDate = Convert.ToDateTime(myReader[4]);
                            resInfo.EndDate = Convert.ToDateTime(myReader[5]);
                            resInfo.Occupied = Convert.ToInt32(myReader[6]);
                            resInfo.TotalPrice = Convert.ToInt32(myReader[7]);
                            resInfo.LenghtOfStay = Convert.ToInt32(myReader[8]);
                            //Desc = (myReader[2]).ToString()
                            listOfReservation.Add(resInfo);    
                        }
               
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return listOfReservation;


        }

        //check if a reservation is in datetime range of another reservation
        // based on id
        public List<ReservationInfo> FilterReservationByDgvDate(DateTime RangeFrom, DateTime RangeTill, int roomId)
        {
    
            List<ReservationInfo> listOfReservation = new List<ReservationInfo>();
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay FROM reservation WHERE NOT (startDate >= @RangeTill OR endDate <= @RangeFrom) AND room_id=@room_id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            { 
                cmd.Parameters.AddWithValue("@RangeTill", RangeTill);
                cmd.Parameters.AddWithValue("@RangeFrom", RangeFrom);
                cmd.Parameters.AddWithValue("@room_id", roomId);
                try
                {
                    MySqlDataReader myReader;
                    conn.Open();
                    using (myReader = cmd.ExecuteReader())
                    {

                        while (myReader.Read())
                        {

                            ReservationInfo resInfo = new ReservationInfo();
                            resInfo.ResId = Convert.ToInt32((myReader[0]));
                            resInfo.RoomId = (myReader[1]).ToString();
                            resInfo.CustomerId = Convert.ToInt32(myReader[2]);
                            resInfo.Desc = (myReader[3]).ToString();
                            resInfo.StartDate = Convert.ToDateTime(myReader[4]);
                            resInfo.EndDate = Convert.ToDateTime(myReader[5]);
                            resInfo.Occupied = Convert.ToInt32(myReader[6]);
                            resInfo.TotalPrice = Convert.ToInt32(myReader[7]);
                            resInfo.LenghtOfStay = Convert.ToInt32(myReader[8]);
                            //Desc = (myReader[2]).ToString()
                            listOfReservation.Add(resInfo);
                            MessageBox.Show("item added");
                        }
               
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return listOfReservation;


        }

    }


    
}

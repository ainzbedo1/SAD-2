using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public ReservationInfo GetReservationInfoById(int resId)
        {
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate, groupStatus, amtPaid FROM reservation id WHERE id = '" + resId + "' ";
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
                            CustomerId = Convert.ToInt32((myReader[2])),
                            Desc = (myReader[3]).ToString(),
                            StartDate = Convert.ToDateTime(myReader[4]),
                            EndDate = Convert.ToDateTime(myReader[5]),
                            Occupied = Convert.ToInt32(myReader[6]),
                            TotalPrice = Convert.ToInt32(myReader[7]),
                            LenghtOfStay = Convert.ToInt32(myReader[8]),
                            RoomRate = Convert.ToInt32(myReader[9])
                            //Desc = (myReader[2]).ToString(),

                        };
                    }
                }

            }

            return null;
        }
        public DataTable FindGroupRes(int resId)
        {
            string query = "SELECT * FROM sad2_db.reservation WHERE reservationId = '"+resId+"',";
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {

                try
                {
                    conn.Open();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        //dt.Columns.Add("CalcDays", typeof(Int32));
                        // dt.Columns.Add("TotalReserveDays", typeof(Int32));

                        //dt.Columns.Add("CalcDays", typeof(Int32));
                        /*
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            //List<string> computeValues = FilterResForMsr(myReservationList[i], startOnDgv, endOnDgv);
                            //dt.Rows[i][9] = computeValues[0];
                            //dt.Rows[i][10] = computeValues[1];
                            //dt.Rows[i][10] = 19;
                            //computeValues.Clear();
                        }
                        */
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return dt;
        }

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

        public long UpdateReservation(int id, int roomId, int customerId, string description, DateTime startDate, DateTime endDate, int occupied, int totalPrice, int lengthOfStay, int rate)
        {
            string query = "UPDATE reservation SET room_id = @room_id, customer_id = @customer_id, description = @description, " +
                "startDate = @startDate, endDate = @endDate, occupied = @occupied, totalPrice = @totalPrice, " +
                "lengthOfStay = @lengthOfStay, rate = @rate WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
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
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    long idReservation = cmd.LastInsertedId;
                    return idReservation;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "UPdating Reservation Failed");

                    return 0;

                }

            }
        }

        public void verifyCustomerInfoAndCreateReservation(CustomerInfo Customer, ReservationInfo ResNow, ReservationCalendarForm calendar) {
            string query = "SELECT * FROM customer WHERE name=@name";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Execute Scalar returns the first column of the first row
                cmd.Parameters.AddWithValue("@name", Customer.Name);
                conn.Open();
                int CustomerExists = Convert.ToInt32(cmd.ExecuteScalar());
                if (CustomerExists > 0)
                {
                    MessageBox.Show("customer with the same name exist please choose " +
                        "another name");
                }
                else
                {
                    // user clicked no
                    try
                    {
                        CustomerDataService customerData = new CustomerDataService();
                        //insert into customer
                        // insert into statement of account
                        // insert into question reservation form
                        // inesrt into customer
                        // insert into reservation
                        long lastInsertedCustomer = customerData.InsertIntoCustomer(Customer.Name, Customer.Company, Customer.Address, Customer.Phone, Customer.Email, Customer.Passport, Customer.Nationality, Customer.Gender, Customer.BirthDate, Customer.BirthPlace, Customer.Comment);
                        //public void InsertIntoReservation(int roomId, int customerId, string description, string checkInDate, string checkOutDate, Boolean occupied, string totalPrice, string lengthOfStay)
                        //reserveNow = GetByRoomNumber(Convert.ToString(roomId));
                        ResNow.CustomerId = Convert.ToInt32(lastInsertedCustomer);

                        long lastInsertReservation = AddReservation(Convert.ToInt32(ResNow.RoomId), ResNow.CustomerId, ResNow.Desc, ResNow.StartDate, ResNow.EndDate, 0, ResNow.TotalPrice, ResNow.LenghtOfStay, ResNow.RoomRate);
                        //calendar.displayReservationButt()
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

                    /*
                // MessageBox is not triggered
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
                        long lastInsertedCustomer = customerData.InsertIntoCustomer(Customer.Name, Customer.Company, Customer.Address, Customer.Phone, Customer.Email, Customer.Passport, Customer.Nationality, Customer.Gender, Customer.BirthDate, Customer.BirthPlace, Customer.Comment);
                        //public void InsertIntoReservation(int roomId, int customerId, string description, string checkInDate, string checkOutDate, Boolean occupied, string totalPrice, string lengthOfStay)
                        //reserveNow = GetByRoomNumber(Convert.ToString(roomId));
                        ResNow.CustomerId = Convert.ToInt32(lastInsertedCustomer);

                        long lastInsertReservation = AddReservation(Convert.ToInt32(ResNow.RoomId), ResNow.CustomerId, ResNow.Desc, ResNow.StartDate, ResNow.EndDate, 0, ResNow.TotalPrice, ResNow.LenghtOfStay, ResNow.RoomRate);
                        //calendar.displayReservationButt()
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            */
        }

        //
        public DataTable MsrDataSource(DateTime start, DateTime end)
        {
            List<ReservationInfo> MsrListReservs = new List<ReservationInfo>();
            return ResDataTable(start, end);


        }
        public DataTable ResDataTable(DateTime startOnDgv, DateTime endOnDgv)
        {
            //public List<ReservationInfo> FilterReservationByDgvDate(DateTime RangeFrom, DateTime RangeTill)
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            //MessageBox.Show(start.ToString()+"my start date");
            //MessageBox.Show(end.ToString()+"my end date");
            ReservationDataService reservationDataService = new ReservationDataService();
            List<ReservationInfo> myReservationList = reservationDataService.ShowAllRes(startOnDgv, endOnDgv);
            ReservationInfo me = myReservationList[1];
            //string query = "SELECT id, room_id, customer_id, description, startDate, endDate, totalPrice, lengthOfStay, rate FROM reservation  WHERE NOT (startDate > @end OR endDate < @start)";
            string query = "SELECT res.id, room.roomNumber, cust.name, res.description, res.startDate, res.endDate, res.totalPrice, res.lengthOfStay, res.rate " +
                "FROM reservation res " +
                "INNER JOIN room room " +
                "ON res.room_id = room.id " +
                "INNER JOIN customer cust " +
                "ON res.customer_id = cust.id " +
                "WHERE NOT (startDate > '2019-01-31 00:00:00' OR endDate < '2019-01-01 00:00:00')";
                
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@end", endOnDgv);
                cmd.Parameters.AddWithValue("@start", startOnDgv);
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        dt.Columns.Add("CalcDays", typeof(Int32));
                        dt.Columns.Add("TotalRevenue", typeof(Int32));
                       // dt.Columns.Add("TotalReserveDays", typeof(Int32));

                        //dt.Columns.Add("CalcDays", typeof(Int32));
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            List<string> computeValues = FilterResForMsr(myReservationList[i], startOnDgv, endOnDgv);
                            dt.Rows[i][9] = computeValues[0];
                            dt.Rows[i][10] = computeValues[1];
                            //dt.Rows[i][10] = 19;
                            //computeValues.Clear();
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return dt;


        }

        public DataTable Occupancy(DateTime startOnDgv, DateTime endOnDgv)
        {

            ReservationDataService reservationDataService = new ReservationDataService();
            List<ReservationInfo> myReservationList = reservationDataService.ShowAllRes(startOnDgv, endOnDgv);
            ReservationInfo me = myReservationList[1];
            RoomDataService myRoomDataService = new RoomDataService();
            int amtOfRooms = myRoomDataService.GetAmtRooms();
            int days = DateTime.DaysInMonth(endOnDgv.Year, endOnDgv.Month);
            int potentialNights = amtOfRooms * days;
            //MessageBox.Show("My amount of rooms" + amtOfRooms.ToString());
            // THe feilds we want a  room.roomNumber, totalRoomNIghts of all, potentialNights
            // totalRoom nights of all is equal to filter running total of calc days
            // potentailnights is equal to daysInMonth * amtOfRooms
            // amtOfrooms is to mysql count(*)
            // 
            string query = "SELECT id, roomNumber from sad2_db.room";

            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@end", endOnDgv);
                cmd.Parameters.AddWithValue("@start", startOnDgv);
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                        dt.Columns.Add("TotRoomNights", typeof(Int32));
                        dt.Columns.Add("PotentNights", typeof(Int32));
                        dt.Columns.Add("OccPer", typeof(String));


                        /*
                        dt.Columns["TotRoomNights"].DefaultValue = 0;
                        foreach (DataColumn col in dt.Columns)
                        {
                            if (col.ColumnName != "id") col.DefaultValue = 0;
                        }
                        */
                        // dt.Columns["TotRoomNights"] = (myobject == null) ? DBNull.Value : myvalue;
                        // dt.Columns.Add("PotentNights", typeof(Int32));
                        // dt.Columns.Add("TotalReserveDays", typeof(Int32));
                        int roomNightsMonth = 0;
                        //dt.Columns.Add("CalcDays", typeof(Int32));
                        int theHell = 0;
                        for (int i = 0; i < amtOfRooms; i++)
                        {
                            for (int x = 0; x < myReservationList.Count; x++)
                            {
                                dt.Columns["TotRoomNights"].DefaultValue = 0;
                                //dt.Columns["Occupancy"].
                                List<string> computeValues = FilterResForMsr(myReservationList[x], startOnDgv, endOnDgv);
                                if (Convert.ToInt32(computeValues[2]) == Convert.ToInt32(dt.Rows[i][0]))
                                {
                                    dt.Columns["TotRoomNights"].DefaultValue = 0;

                                    //Convert.ToInt32(dt.Rows[0]["field_name"]);

                                    theHell += Convert.ToInt32(computeValues[0]);
                                    dt.Rows[i]["TotRoomNights"] = theHell;
                                    //dt.Rows[i]["TotRoomNights"] = Convert.ToInt32(computeValues[0]) + Convert.ToInt32(dt.Rows[i]["TotRoomNights"]);
                                }

                            }
                            theHell = 0;
                            dt.Rows[i]["PotentNights"] = potentialNights;

                            /*
                            roomNightsMonth += Convert.ToInt32(computeValues[0]);
                            MessageBox.Show(roomNightsMonth.ToString());
                            */
                        }
                        foreach (DataRow items in dt.Rows)
                        {
                            if (items[2] == DBNull.Value)
                            {
                                 items[2] = 0;

                            }
                        }
                        foreach (DataRow items in dt.Rows)
                        {
                            decimal roomNights = Math.Round(((Convert.ToDecimal(items["TotRoomNights"])/potentialNights) * 100),2);                          
                            string format = roomNights.ToString() + (" %");
                            //MessageBox.Show((Convert.ToDouble(items["TotRoomNights"]) / potentialNights).ToString());

                            items["OccPer"] = format;


                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return dt;


        }

        // public virtual void createButton(int centerPointFirstCell, int y1, int totalWidth, int reserveId, int roomId)

        // remeber that this foreach is guarnteed filter
        // meaning all reservation date ranges are valid for this month
        public void CalcOccupancy()
        {

        }
        public List<string> FilterResForMsr(ReservationInfo item, DateTime startDateOnDGV, DateTime endDateOnDGV)
        {
            List<string> itemsForDgv = new List<string>();
            int calcDays = 0;
            int calcAccMonth = 0;
            int totalResDays = 0;

            string roomNumber;
            //if date of reservation occurs inclusively in datagridview
            if (item.StartDate.Date >= startDateOnDGV.Date && item.EndDate.Date <= endDateOnDGV.Date)
            {
                calcDays = item.LenghtOfStay;
                calcAccMonth = item.TotalPrice;
                roomNumber = item.RoomId;

                itemsForDgv.Add(calcDays.ToString());
                itemsForDgv.Add(calcAccMonth.ToString());
                itemsForDgv.Add(roomNumber.ToString());

                //itemsForDgv.Add
            }

            // there is backflow from previous dates
            // aka if a reservation ends on this month but starts in a previous month
            else if (item.StartDate.Date <= startDateOnDGV.Date && item.EndDate.Date <= endDateOnDGV.Date)
            {
                if (item.EndDate.Date == startDateOnDGV)
                {
                    calcDays = 1;
                    calcAccMonth = calcDays * item.RoomRate;
                    roomNumber = item.RoomId;

                    itemsForDgv.Add(calcDays.ToString());
                    itemsForDgv.Add(calcAccMonth.ToString());
                    itemsForDgv.Add(roomNumber.ToString());



                }
                else
                {
                    MessageBox.Show(calcDays.ToString());
                    calcDays = (item.EndDate - startDateOnDGV).Days;
                    calcAccMonth = calcDays * item.RoomRate;
                    roomNumber = item.RoomId;


                    itemsForDgv.Add(calcDays.ToString());
                    itemsForDgv.Add(calcAccMonth.ToString());
                    itemsForDgv.Add(roomNumber.ToString());

                }


            }

            // if there is overflow on next dates
            // aka if reservation starts on the month now but ends on a later month

            else if ((item.StartDate.Date <= endDateOnDGV.Date && item.StartDate.Date >= startDateOnDGV.Date) && item.EndDate.Date >= endDateOnDGV.Date)
            {

                if (endDateOnDGV == item.EndDate)
                {

                    calcDays = (item.StartDate - endDateOnDGV).Days;
                    calcAccMonth = calcDays * item.RoomRate;
                    roomNumber = item.RoomId;

                    itemsForDgv.Add(calcDays.ToString());
                    itemsForDgv.Add(calcAccMonth.ToString());
                    itemsForDgv.Add(roomNumber.ToString());

                }
                else
                {
                    calcDays = (item.StartDate - endDateOnDGV).Days;
                    calcAccMonth = calcDays * item.RoomRate;
                    roomNumber = item.RoomId;

                    itemsForDgv.Add(calcDays.ToString());
                    itemsForDgv.Add(calcAccMonth.ToString());
                    itemsForDgv.Add(roomNumber.ToString());

                }

            }

            // if there is overflow on both ends
            else if (item.StartDate.Date <= endDateOnDGV.Date && item.EndDate.Date >= endDateOnDGV.Date)
            {
                calcDays = 31;
                calcAccMonth = calcDays * item.RoomRate;
                roomNumber = item.RoomId;

                itemsForDgv.Add(calcDays.ToString());
                itemsForDgv.Add(calcAccMonth.ToString());
                itemsForDgv.Add(roomNumber.ToString());


            }
            else
            {
                MessageBox.Show("an error has occured");
            }
            return itemsForDgv;


            
        }
    
    
        
        /*
        // filter reservations according to there start and end reservation dates
        // return back a list of items for the datagrid to use 
        public List<string> FilterResForMsr(DateTime startDateOnDGV, DateTime endDateOnDGV, DateTime resStart, DateTime resEnd)
        {
            List<string> ItemsToInsert = new List<string>();
            //if date of reservation occurs inclusively in datagridview
            if (resStart.Date >= startDateOnDGV.Date && resEnd.Date <= endDateOnDGV.Date)
            {
                int
            }

            // there is backflow from previous dates
            // aka if a reservation ends on this month but starts in a previous month
            else if (resStart.Date <= startDateOnDGV.Date && resEnd.Date <= endDateOnDGV.Date)
            {


            }

            // if there is overflow on next dates
            // aka if reservation starts on the month now but ends on a later month

            else if ((resStart.Date <= endDateOnDGV.Date && resStart.Date >= startDateOnDGV.Date) && resEnd.Date >= endDateOnDGV.Date)
            {
            }

            // if there is overflow on both ends
            //

            else if (resStart.Date <= endDateOnDGV && resEnd.Date >= endDateOnDGV.Date)
            {
            }
            else
            {
                MessageBox.Show("an error has occured");
            }
        }
        */
    
        
        public List<ReservationInfo> ShowAllRes(DateTime start, DateTime end)
        {
            //public List<ReservationInfo> FilterReservationByDgvDate(DateTime RangeFrom, DateTime RangeTill)
            List<ReservationInfo> listOfReservation = new List<ReservationInfo>();
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            //MessageBox.Show(start.ToString()+"my start date");
            //MessageBox.Show(end.ToString()+"my end date");
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate FROM reservation  WHERE NOT (startDate > @end OR endDate < @start)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@end", end);
                cmd.Parameters.AddWithValue("@start", start);
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
                            resInfo.CustomerId = Convert.ToInt32((myReader[2]));
                            resInfo.Desc = (myReader[3]).ToString();
                            resInfo.StartDate = Convert.ToDateTime(myReader[4]);
                            resInfo.EndDate = Convert.ToDateTime(myReader[5]);
                            resInfo.Occupied = Convert.ToInt32(myReader[6]);
                            resInfo.TotalPrice = Convert.ToInt32(myReader[7]);
                            resInfo.LenghtOfStay = Convert.ToInt32(myReader[8]);
                            resInfo.RoomRate = Convert.ToInt32(myReader[9]);
                            //Desc = (myReader[2]).ToString()
                            listOfReservation.Add(resInfo);
                            //MessageBox.Show("DSAFSADf");
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



        // Step 1: need to filter out reservations according if dgv month and year is present in the reservation
        // Step 2: Add this information to the datatable 
        // Step 3: When MSR loads send Datatable
        // step 4: DataTable should consist of 
        /*
        public DataTable CreateMonthlyReport(DateTime end, int month)
        {
              
            
            
            //FilterReservationByDgvDate
            //return dt = MSRFilter(dgvStartMonthDay, dgvEndMonthDay);

        }
        */
        
        public DataTable MSRFilter(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate FROM reservation WHERE NOT (startDate >= @RangeTill OR endDate <= @RangeFrom) AND room_id=@room_id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RangeTill", start);
                cmd.Parameters.AddWithValue("@RangeFrom", end);
                try
                {
                    MySqlDataReader myReader;
                    conn.Open();
                    using (myReader = cmd.ExecuteReader())
                    {

                        while (myReader.Read())
                        {
                            //newRow = dt.NewRow();
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
                            resInfo.RoomRate = Convert.ToInt32(myReader[8]);
                            //Desc = (myReader[2]).ToString()

                            dt.Rows.Add(resInfo);

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return dt;



        }



        //check if a reservation is in datetime range of another reservation
        // based on reservations room_id
        public List<ReservationInfo> FilterReservationByDgvDate(DateTime RangeFrom, DateTime RangeTill, int roomId)
        {
    
            List<ReservationInfo> listOfReservation = new List<ReservationInfo>();
            //SELECT* FROM Product_salesWHERE NOT(From_date > @RangeTill OR To_date < @RangeFrom)
            string query = "SELECT id, room_id, customer_id, description, startDate, endDate, occupied, totalPrice, lengthOfStay, rate FROM reservation WHERE NOT (startDate >= @RangeTill OR endDate <= @RangeFrom) AND room_id=@room_id";
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
                            resInfo.RoomRate = Convert.ToInt32(myReader[8]);
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
      
    }


    
}

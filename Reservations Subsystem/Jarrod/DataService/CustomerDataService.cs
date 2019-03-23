using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Reservations_Subsystem
{
    public class CustomerDataService
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        public long InsertIntoCustomer(string name, string company, string address, string phone, string email, string passport, string nationality, string gender, DateTime birthdate, string birthplace, string comment)
        {
            string query = "INSERT INTO customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace, comment) VALUES( @name, @company, @address, @phone, @email, @passport, @nationality, @gender, @birthdate, @birthplace, @comment)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@passport", passport);
                cmd.Parameters.AddWithValue("@nationality", nationality);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@birthplace", birthplace);
                cmd.Parameters.AddWithValue("@comment", comment);

                try
                {
                    // conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    //get last inserted ID
                    long idCustomer = cmd.LastInsertedId;
                    return idCustomer;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" customer insert failed "+ex.ToString());
                    return 0;
                }

            }

        }
        public DataTable GetAllCustomers()
        {
            DataTable dgvListOfCust = new DataTable();
            string query = "SELECT * FROM customer";
            using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
            {
                try
                {                   
                    blah.Fill(dgvListOfCust);
                    MessageBox.Show("customers loaded in datagridview");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed customer load "+ex.ToString());
                }
            }
            return dgvListOfCust;
            
        }
        public DataTable CheckDuplicateNames(string name)
        {
            DataTable dgvListOfCust = new DataTable();
            string query = "SELECT name FROM sad2_db.customer WHERE name = '"+name+"'";
            using (MySqlDataAdapter blah = new MySqlDataAdapter(query, conn))
            {
                try
                {
                    blah.Fill(dgvListOfCust);
                    MessageBox.Show("customers loaded in datagridview");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed customer load " + ex.ToString());
                }
            }
            return dgvListOfCust;

        }
        public AutoCompleteStringCollection AutoCompleteCollection()
        {
            AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
            string query = "SELECT name FROM customer";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                try
                {
                    MySqlDataReader myReader;
                    conn.Open();
                    using (myReader = cmd.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            nameCollection.Add((myReader[0]).ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            MessageBox.Show(nameCollection[0].ToString());

            return nameCollection;

        }
        public List<ReservationInfo> FilterReservationByDgvDate(DateTime start, DateTime end)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "Filter reservations failed");
                    return null;
                }
            }
            return listOfReservation;


        }

        public long UpdateCustomer(int cust_id, string name, string company, string address, string phone, string email, string passport,
            string nationality, string gender, DateTime birthdate, string birthplace, string comment)
        {
            string query = "UPDATE customer SET name = @name, company = @company, address = @address, " +
                "phone = @phone, email = @email, passport = @passport, nationality = @nationality, " +
                "gender = @gender, birthdate = @birthdate, birthplace = @birthplace, comment = @comment WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", cust_id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@passport", passport);
                cmd.Parameters.AddWithValue("@nationality", nationality);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@birthplace", birthplace);
                cmd.Parameters.AddWithValue("@comment", comment);
                //cmd.Parameters.AddWithValue("@description", description);
                try
                {
                    MessageBox.Show("customer updated");
                    conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    long idReservation = cmd.LastInsertedId;
                    return idReservation;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "UPdating custsomer failed");

                    return 0;

                }

            }
        }
        public CustomerInfo GetCustomerInfoById(int customerId)
        {
            string query = "SELECT id, name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace FROM customer WHERE id = '" + customerId + "' ";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    try
                    {

                        if (myReader.Read())
                        {
                            return new CustomerInfo
                            {
                                Id = (myReader[0].ToString()),
                                Name = (myReader[1].ToString()),
                                Company = (myReader[2].ToString()),
                                Address = (myReader[3].ToString()),
                                Phone = (myReader[4].ToString()),
                                Email = (myReader[5].ToString()),
                                Passport = (myReader[6].ToString()),
                                Nationality = (myReader[7].ToString()),
                                Gender = (myReader[8].ToString()),
                                BirthDate = Convert.ToDateTime((myReader[9])),
                                BirthPlace = (myReader[10].ToString())

                                /*
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
                                */

                            };
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }


            }

            return null;
        }
        public CustomerInfo GetCustomerInfoByName(string name)
        {
            string query = "SELECT id, name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace FROM customer WHERE name = '"+name+"' ";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                MySqlDataReader myReader;
                conn.Open();
                using (myReader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (myReader.Read())
                        {
                            return new CustomerInfo
                            {
                                Id = (myReader[0].ToString()),
                                Name = (myReader[1].ToString()),
                                Company = (myReader[2].ToString()),
                                Address = (myReader[3].ToString()),
                                Phone = (myReader[4].ToString()),
                                Email = (myReader[5].ToString()),
                                Passport = (myReader[6].ToString()),
                                Nationality = (myReader[7].ToString()),
                                Gender = (myReader[8].ToString()),
                                BirthDate = Convert.ToDateTime((myReader[9])),
                                BirthPlace = (myReader[10].ToString())

                                /*
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
                                */

                            };
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }


            }

            return null;
        }
        /*
        public SearchData(string search)
        {
            conn.Open();
            string query = "SELECT * FROM customer WHERE name like '%" + search + "%'";
            adt = new MySqlDataAdapter(query, conn);
        }
        */

        // public DataTable customerDGV

    }
}

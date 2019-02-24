using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.Windows.Forms;

namespace Reservations_Subsystem
{
    class CustomerDataService
    {
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=sad2_db;Uid=root;Pwd=root;");
        public long InsertIntoCustomer(string name, string company, string address, string phone, string email, string passport, string nationality, string gender, DateTime birthdate, string birthplace)
        {
            string query = "INSERT INTO customer(name, company, address, phone, email, passport, nationality, gender, birthdate, birthplace) VALUES( @name, @company, @address, @phone, @email, @passport, @nationality, @gender, @birthdate, @birthplace)";
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

                try
                {
                    // conn.Open();
                    MessageBox.Show("success customer insert");
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    //get last inserted ID
                    long idCustomer = cmd.LastInsertedId;
                    MessageBox.Show(idCustomer.ToString() +"fasojfsda");
                    return idCustomer;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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

    }
}

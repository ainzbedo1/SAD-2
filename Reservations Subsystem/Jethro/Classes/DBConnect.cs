using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    class DBConnect
    {
        //Initialize Values
        public MySqlConnection connect()
        {
            string connectionString = "SERVER=localhost;"
                                    + "DATABASE=sad_db;"
                                    + "UID=root;"
                                    + "PASSWORD=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}

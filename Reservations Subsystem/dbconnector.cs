using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    class dbconnector
    {
        public MySqlConnection connector()
        {
            String connecttodb = "server=localhost;username=root;password=root;database=sad2_db";
            MySqlConnection conn = new MySqlConnection(connecttodb);
            return conn;
        }
    }
}

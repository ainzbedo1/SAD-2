using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Reservations_Subsystem
{
    public class ROSQueries
    {
        private DBConnect conn = new DBConnect();
        private DataTable dataTable = new DataTable();

        public ROSQueries()
        {
        }

        public void refreshMenu()
        {

        }
    }
}

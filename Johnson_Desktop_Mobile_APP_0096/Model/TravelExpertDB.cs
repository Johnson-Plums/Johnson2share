using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class TravelExpertDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=projectteamno7.database.windows.net;Initial Catalog=travelexperts;User ID=Runner;Password=Travel123";
            return new SqlConnection(connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Query
{
    //create a connection class
    public class Connection
    {
       // make a connection by the stirng name, if no name, show null.
        static string GetConnectionStringByName(string name)
        {
            // initial set as null, no connection
            string returnValue = null;
           // get name
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
           // return name if name exist, return null if not
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        //
        public static SqlConnection GetConnection()
        // copy and paste the connectoin string from txt to here
        {
            string connectionString = @"Data Source = localhost\sqlexpress; Initial Catalog = TravelExperts; Integrated Security = True"; 
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}

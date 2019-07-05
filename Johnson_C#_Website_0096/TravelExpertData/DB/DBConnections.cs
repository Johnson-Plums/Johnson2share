using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
    // DBControls responsible for distributing the SQL connection to different DB related classes.
    // Created this so other cs files can easily reuse the GetConnection() string without creating the connection in class
    //original sql:localhost\sqlexpress

    public static class UnversalDBControls
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = DESKTOP-1C9HJS2; Initial Catalog = TravelExperts004; Integrated Security = True");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData
{
    /// <summary>

    /// 
    /// UniversalDBControls responsible for distributing the SQL connection to different DB related classes.
    /// Created this so other cs files can easily reuse the GetConnection() string without creating the connection in class
    /// </summary>
    public static class UnversalDBControls
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source = localhost\sqlexpress; Initial Catalog = TravelExperts004; Integrated Security = True");
        }
    }
}

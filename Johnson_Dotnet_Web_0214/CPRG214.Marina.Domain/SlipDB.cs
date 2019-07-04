using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CPRG214.Framework.Data;

// CPRG-214-MA1 Group 4 
//Author: Josh, Wei, Johnson
// May 5, 2019
namespace CPRG214.Marina.Domain
{
    // Create a slip Database Class
    public class SlipDB
    {// get the connection string from sql express generated string
        private static string connectionString = @"server=.\sqlexpress;database=Marina;trusted_connection=True";
        // create an object for DB as dbo
        private static DBObject dbo = DBObject.Instance;

        // create a function to get a list of slips by dock ID
        public static List<Slip> GetAvailableSlipsFromDock(int dockID = 0) // default id set to 0
        {
            // create an instance of list as slips, where the items as slip class objects
            var slips = new List<Slip>();
            // build sql query to search slip DB table 
            var sql = "SELECT ID,Width,Length,DockID FROM Slip " +
                      "WHERE ID NOT IN (SELECT SlipID FROM Lease) " + // not including the id already been leased out
                      (dockID != 0 ? $"AND DockID={dockID}" : ""); // if no ID , get all slips
            // pass in connectin string and get provider
            dbo.ConnectionString = connectionString;
            dbo.SetProvider("System.Data.SqlClient");
            // Adope the query method to plug in 3 parameters and pass to reader
            using (var reader = dbo.Query(sql, CommandType.Text, null))
            {
                while (reader.Read())
                {
                    // create an instance of slip class
                    var s = new Slip
                    {
                        // get parameters from reader and pass them to slip as contents
                        SlipID = reader.GetInt32(0),
                        Width = reader.GetInt32(1),
                        Length = reader.GetInt32(2),
                        DockID = reader.GetInt32(3)
                    };
                    // add the Slip object to the list of slips
                    slips.Add(s);
                }
            }
            // output list of slips
            return slips;
        }

        // create an method for customer to select a slip for a lease to go
        public static bool LeaseSelectedSlip(Slip s, Customer c)
        {
            // build sql query
            string sql = "INSERT INTO Lease(SlipID,CustomerID) VALUES(@SlipID,@CustomerID)";
            // pass in connection string
            dbo.ConnectionString = connectionString;
            dbo.SetProvider("System.Data.SqlClient");
            // create a slip id parameter instance to accept the parameters from the input Slip class object
            var slipIDPar = dbo.CreateParameter();
            slipIDPar.Value = s.SlipID;
            slipIDPar.ParameterName = "@SlipID";
            // create a customer id parameter to accept the parameters from Customer class object
            var custIDPar = dbo.CreateParameter();
            custIDPar.Value = c.CustomerID;
            custIDPar.ParameterName = "@CustomerID";

            // create interface data base parameter instance and input slip id paramter and customer id parameter
            var parameters = new IDataParameter[] { slipIDPar,custIDPar };
            // use non query mehtod, plug in 3 variables and pass them to a variable as integer
            var rowsAffected = dbo.NonQuery(sql, CommandType.Text, parameters);
            // if any commands get executed, show success
            return rowsAffected > 0 ? true : false;
        }
    }
}

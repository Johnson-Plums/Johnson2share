using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG214.Framework.Data;
// CPRG-214-MA1 Group 4 
//Author: Josh, Wei, Johnson
// May 5, 2019
namespace CPRG214.Marina.Domain
{
    //Create Customer Database

    public class CustomerDB
    {
        // get connection string from sqlexpress database generated string
        private static string connectionString = @"server=.\sqlexpress;database=Marina;trusted_connection=True";
        // create Database object as dbo
        private static DBObject dbo = DBObject.Instance;
        
        // create a function to get customers by a list where the Customer class as members in the list
        public static List<Customer> GetAllCustomers()
        { // create an instance of list as customers
            var customers = new List<Customer>();
            // build sql query
            var sql = "SELECT ID,FirstName,LastName,Phone,City FROM Customer";
            // pass in connectin string
            dbo.ConnectionString = connectionString;
            // get provider
            dbo.SetProvider("System.Data.SqlClient");
            // plug in 3 parameters to query and pass it to Interface Data Reader
            using (var reader = dbo.Query(sql, CommandType.Text, null))
            {
                while (reader.Read())
                {
                    // create c as an instance of Customer
                    var c = new Customer()
                    {// read the data and pass them to corresponding parameters in customer as c
                        CustomerID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        City = reader.GetString(4)
                    };
                    // add c as item to the list 
                    customers.Add(c);
                }
            }
            // output list
            return customers;
        }
      // INSERT Customer
      // create a method to insert customer,, no instance,  output yes or no
        public static bool InsertCustomer(Customer c)
        {
            // build sql query
            string sql = "INSERT INTO Customer(FirstName,LastName,Phone,City) VALUES(@F,@L,@P,@C)";
            // pass in connection string
            dbo.ConnectionString = connectionString;
            // get provoder
            dbo.SetProvider("System.Data.SqlClient");
            // read from c get 4 parameters and pass them to Interface database parameter as variables
            var fNamePar = dbo.CreateParameter();
            fNamePar.Value = c.FirstName;
            fNamePar.ParameterName = "@F";
            var lNamePar = dbo.CreateParameter();
            lNamePar.Value = c.LastName;
            lNamePar.ParameterName = "@L";
            var phonePar = dbo.CreateParameter();
            phonePar.Value = c.Phone;
            phonePar.ParameterName = "@P";
            var cityPar = dbo.CreateParameter();
            cityPar.Value = c.City;
            cityPar.ParameterName = "@C";
            // create a Interface Database parameter instance by plugging in the 4 variables
            var parameters = new IDataParameter[] { fNamePar, lNamePar, phonePar, cityPar };
            // Use NonQuery method, input 3 parameters and execute rows
            var rowsAffected = dbo.NonQuery(sql, CommandType.Text, parameters);
            // if any rows get executed, success as output
            return rowsAffected > 0 ? true : false;
        }

        // SEARCH Lease Record
        public static List<Slip> FindLeasingHistory(Customer c)
        {
            // create a new list instance for slip
            var leasedSlips = new List<Slip>();
            // build sql to search database
            var sql = "SELECT Slip.ID,Width,Length,DockID FROM Lease,Slip WHERE Lease.SlipID=Slip.ID AND CustomerID=@CustomerID";
            dbo.ConnectionString = connectionString;
            dbo.SetProvider("System.Data.SqlClient");
            // create Interface Parameter instance to accept the parametes
            var cIDPar = dbo.CreateParameter();
            // get the ID and pass it to Customer ID parameter 
            cIDPar.ParameterName = "@CustomerID";
            cIDPar.Value = c.CustomerID;
            // create instance of Interface database parameter, bind it with customer id parameter
            var parameters = new IDataParameter[] { cIDPar };

            // Use Query method, plug in 3 parameter, get result and pass to reader
            using (var reader = dbo.Query(sql, CommandType.Text, parameters))
            {
                while (reader.Read())
                {
                    // create an instance of slip to hold values
                    var slip = new Slip
                    {
                        // read slips database and get values by index and pass to slips variables
                        SlipID = reader.GetInt32(0),
                        Width = reader.GetInt32(1),
                        Length = reader.GetInt32(2),
                        DockID = reader.GetInt32(3)
                    };
                    // add the slip to the list
                    leasedSlips.Add(slip);
                }
            }
            // out put the lease record as list of slips
            return leasedSlips;
        }
    }
}

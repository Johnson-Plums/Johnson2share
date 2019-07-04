using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CPRG-214-MA1 Group 4 
//Author: Josh, Wei, Johnson
// May 5, 2019
namespace CPRG214.Framework.Data
{
 // Create a Data base object class
    public class DBObject
    {
        // create a DbProviderFactory classs as factory
        DbProviderFactory Factory { get; set; }
        // create an DB object as _instance
        private static readonly DBObject _instance = new DBObject();
        // construct an empty function  
        private DBObject()
        {
        }

   // get the DB object as instance 
        public static DBObject Instance { get => _instance; }

   // get the connetion string
        public string ConnectionString { get; set; }

       // set provider 
        public void SetProvider(string provider)
        {
            Factory = DbProviderFactories.GetFactory(provider);
        }
        // Get parameters
        public IDataParameter CreateParameter()
        {
            return Factory.CreateParameter(); 
        }

        //    // use Non query method, plug in 3 variables
        //        public int NonQuery(string sql, CommandType cmdType, IDataParameter[] parameters)
        //        {
        //            if (Factory == null) // no provider or factory there
        //                throw new Exception("Please set up the provider values.");
        //            // try and catch for the connection
        //            try
        //            {// create a DB connectin to factory table
        //                using (var conn = Factory.CreateConnection())
        //                {// pass in connection string
        //                    conn.ConnectionString = ConnectionString;  
        //                    // create a data base command
        //                    var cmd = conn.CreateCommand();
        //                    // pass in variables sql and command type
        //                    cmd.CommandText = sql;
        //                    cmd.CommandType = cmdType;
        //                    // if any parametes, throw in
        //                    if (parameters != null)
        //                        cmd.Parameters.AddRange(parameters);
        //                    // connection open
        //                    conn.Open();
        //                    var rowsAffected = cmd.ExecuteNonQuery();
        //                    // any commands get executed, means succes
        //                    return rowsAffected;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex);
        //                throw new Exception("Exception Erros.",ex);
        //            }
        //        }
        //   // Use Query method, plug in 3 variables and pass to reader
        //        public IDataReader Query(string sql, CommandType cmdType, IDataParameter[] parameters)
        //        {
        //            if (Factory == null)
        //                throw new Exception("Please set up provider to show factory values.");
        //            // try to catch error
        //            try
        //            {// create a data base conncetion to factory table
        //                var conn = Factory.CreateConnection();
        //                // pass in connectin string
        //                conn.ConnectionString = ConnectionString;
        //                // create DB comand class as cmd 
        //                var cmd = conn.CreateCommand();
        //                // pass in sql and command type
        //                cmd.CommandText = sql;
        //                cmd.CommandType = cmdType;
        //                // if not empty, add parameters array in
        //                if (parameters != null) 
        //                    cmd.Parameters.AddRange(parameters);

        //                conn.Open(); // connect
        //                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); 
        //                // use commander behavior class to connect and close after use
        //                return reader;
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex);
        //                throw new Exception("Exception Erros.", ex);
        //            }
        //        }
        //    }
    }

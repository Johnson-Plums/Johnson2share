using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    
   // create a table for user name and hashed pw
   // create the DB login class for admin
    public class AdminLoginDB
    {
        public string GetAdminAgentHashedPasswordById(int AdminID)
        {
            string selectPassword = "SELECT AgentID, AgentName, AgentPassword FROM AgentLogin WHERE AgentID = " + AdminID;
            SqlConnection conn = Connection.GetConnection();
            string hashpassword = "";
            SqlCommand cmd = new SqlCommand(selectPassword, conn);

            conn.Open();
            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    hashpassword = Convert.ToString(rdr["AgentPassword"]);
                }
                return hashpassword;
            }
        }
        // make a method to tranfer the string pw to  hashed pw 
        public string GetHashCode(string pass) 
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(pass);

            return hashedPassword;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    
// create a Login class 
// input id to connect DB, then get hashed pw from database and compare with local hashed pw 
// if match ok, let in
    public class LoginDB
    {
        public string GetAgentHashedPasswordById(int AgentID) 

        {

            string selectPassword = "SELECT AgentID, AgentName, AgentPassword FROM AgentLogin WHERE AgentID = " + AgentID;
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
        // create a method to convert input string to hashed value string.
        public string GetHashCode(string pass) 
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(pass);

            return hashedPassword;
        }
    }
}

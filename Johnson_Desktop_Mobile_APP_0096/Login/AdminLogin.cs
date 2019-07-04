using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    
    // create a class for admin to log in
    public class AdminLogin
    {
        public int AdminID { get; set; } 
        public string AdminName { get; set; } 
        public string AdminPassword { get; set; } 

     // function to get admin input values and pass to DB Parameters
        public AdminLogin(int user, string name, string pass)
        {

            this.AdminID = user;
            this.AdminName = name;
            this.AdminPassword = pass; 
        }
    }
}

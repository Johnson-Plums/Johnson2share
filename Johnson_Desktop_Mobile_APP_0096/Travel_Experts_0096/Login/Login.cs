using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
   
    // create login class 
    public class Login
    {
        
        public int AgentID { get; set; } 
        public string AgentName { get; set; }
        public string AgentPassword { get; set; } 

   // create a method to get input value and pass them to login class DB parameters
        public Login(int user, string name, string pass)
        {

            this.AgentID = user;
            this.AgentName = name;
            this.AgentPassword = pass;
        }

      
    }
}



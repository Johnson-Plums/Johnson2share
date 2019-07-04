using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// CPRG-214-MA1 Group 4 
//Author: Josh, Wei, Johnson
// May 5, 2019

namespace CPRG214.Marina.Domain
{ // create Customer class 
// acquire values by set and get
    public class Customer
    {
        public int? CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Model
{
   // create suppliers class
    public class Suppliers
    {
        //set variables
        private int supplierId;
        private string supName;


        // Construct the class
        public Suppliers(int supplierId, string supName)
        {
            SupplierId = supplierId;
            SupName = supName;
        }
        // validate and pass values to parameters
        public string SupName
        {
            get => supName;
            set => supName = value;
        }
        public int SupplierId
        {
            get => supplierId;
            set
            {
                if (value > 0)
                {
                    supplierId = value;
                }
            }
        }

      
    }
}

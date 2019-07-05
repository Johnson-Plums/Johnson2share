using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
    // Products definitions
   // Responsible for storing Information about the Products
   
    public class Products
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }

     
        // Creates a copy of the current Products
   
        public Products CopyProduct()
        {
            Products copy = new Products();
            copy.ProdName = this.ProdName;
            copy.ProductId = this.ProductId;
            return copy;
        }

    }
}

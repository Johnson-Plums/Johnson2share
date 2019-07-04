using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // create packages products suppliers relationship Agent Class
    public class Packages_Products_Suppliers
    {
        //variables
        private int packageId;
        private int productSupplierId;

        // set up empty constructors
        public Packages_Products_Suppliers() { }
        // construct Item identifier
        public Packages_Products_Suppliers(int pId, int psId)
        {
            PackageId = pId;
            ProductSupplierId = psId;
        }

       // get and pass parameter values
        public int PackageId
        {
            get => packageId;
            set => packageId = value;
        }
        public int ProductSupplierId
        {
            get => productSupplierId;
            set => productSupplierId = value;
        }
    }
}

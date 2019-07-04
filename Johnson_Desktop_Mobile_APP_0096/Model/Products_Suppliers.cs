using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // create a class for products_suppliers relationship table
    public class Products_Suppliers
    {
        // set variables
        private int productSupplierId;
        private int productId;
        private int supplierId;

        // Construct and empty constructor as default
        public Products_Suppliers() { }
        // construct indentity 
        public Products_Suppliers(int pId, int sId)
        {
            ProductId = pId;
            SupplierId = sId;
        }

        public Products_Suppliers(int psId,int pId, int sId)
        {
            ProductSupplierId = psId;
            ProductId = pId;
            SupplierId = sId;
        }

       // get and pass values
        public int ProductSupplierId
        {
            get => productSupplierId;
            set => productSupplierId = value;
        }
        public int ProductId
        {
            get => productId;
            set => productId = value;
        }
        public int SupplierId
        {
            get => supplierId;
            set => supplierId = value;
        }
    }

}

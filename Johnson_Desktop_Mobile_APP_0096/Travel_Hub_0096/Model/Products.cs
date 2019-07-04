using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    // Create a class of products
    public class Products
    {
        private int productId; 
        private string ProdName; 

       //construct and empty constructor
        public Products() { }

        public Products(int productId, string ProdName)
        {
            ProductId = productId;
            ProductName = ProdName;
        }
        // construtor for indentity
        public Products(string ProdName)
        {
            ProductName = ProdName;
        }
        // validate , get and pass variables
        public int ProductId 
        {
            get => productId;
            set
            {
                if (value > 0)
                {
                    productId = value;
                }
            }
        }
        public string ProductName
        {
            get => ProdName;
            set => ProdName = value;
        } 

    }
}

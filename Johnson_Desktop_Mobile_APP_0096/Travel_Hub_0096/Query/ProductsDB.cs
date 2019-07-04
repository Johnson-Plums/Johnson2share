using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{

    // CREATE  A CLASS for ProductsDB
    public class ProductsDB
    {
        // create a list for products objects
        public static List<Products> GetProducts()
        {
            Products product = null;
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT ProductId, ProdName " +
                    "FROM Products " +
                    "ORDER BY ProdName;";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Products> productList = new List<Products>();
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    product = new Products((int)reader["ProductId"], (string)reader["ProdName"]);
                    productList.Add(product); // Add to return list
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return productList;
        }

        // GET DATA
        public static Products GetProducts(int prodID)
        {
            Products product = null;
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT ProductId, ProdName " +
                    "FROM Products " +
                    "WHERE ProductId = @id;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", prodID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    product = new Products((int)reader["ProductId"], (string)reader["ProdName"]);
                    return product;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        // GET DATA BY ID
        public static Products GetProductID(int productID)
        {
            SqlConnection connection = Connection.GetConnection(); // instantiate the sql connection
            string selectStatement = "SELECT ProductID, ProdName " +
                           "FROM Products " +
                           "WHERE ProductID = @ProductID"; // sql statment to get productID
            SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@ProductID", productID); // value comes from the method's argument
            try
            {
                connection.Open(); // Open the connection
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    Products prod = new Products();
                    prod.ProductId = (int)reader["ProductID"];
                    prod.ProductName = (string)reader["ProdName"].ToString();
                    return prod;
                }
                else
                {
                    return null;
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int InsertProduct(Products product) // method for adding a new product to the DB
        {
            SqlConnection connection = Connection.GetConnection();
            string insertStatement = "INSERT INTO Products (ProdName) " +
                                    "VALUES(@ProdName)";
            SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@ProdName", product.ProductName);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                string selectQuery = "SELECT IDENT_CURRENT('Products') FROM Products";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                int productID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return productID;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        throw new DuplicateKeyException(string.Format("Duplicate ID entry, please enter a different ID and try again {0}", product.ProductId));
                    default:
                        throw;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        // DELETE DATA
        public static bool DeleteProduct(Products product)
        {
            SqlConnection connection = Connection.GetConnection();
            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProdName = @ProdName;";
            SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@ProdName", product.ProductName);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateProduct (Products oldProduct, Products newProduct)
        {
            SqlConnection connection = Connection.GetConnection();
            string updateStatement = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductId = @OldProductID " + // this identifies which record needs to be updated
                                     "AND ProdName = @OldProdName ";
            SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewProdName", newProduct.ProductName);
            command.Parameters.AddWithValue("@OldProdName", oldProduct.ProductName);
            command.Parameters.AddWithValue("@OldProductID", oldProduct.ProductId);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) return true;
                else return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        // DUPLICATE ID EXCEPTION HANLLE
        public class DuplicateKeyException : Exception
        {
            public DuplicateKeyException(string message)
               : base(message)
            {
            }
        }
    }
}


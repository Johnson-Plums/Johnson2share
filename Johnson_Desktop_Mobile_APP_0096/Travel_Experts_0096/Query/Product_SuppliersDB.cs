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
    // Create a Product_SuppliersDB class to achieve CRUD operations
    public class Product_SuppliersDB
    { // creatge a list to store the information
        public static List<Products_Suppliers> GetSuppliers()
        {
            Products_Suppliers pSupplier = null;

            SqlConnection conn = Connection.GetConnection();

            string query = "SELECT ProductSupplierId, ProductId, SupplierId " +
                    "FROM Products_Suppliers;";

            SqlCommand cmd = new SqlCommand(query, conn);
            List<Products_Suppliers> psList = new List<Products_Suppliers>();
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pSupplier = new Products_Suppliers((int)reader["ProductSupplierId"],(int)reader["ProductId"], (int)reader["SupplierId"]);
                    psList.Add(pSupplier); 
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
            return psList;
        }
        // INSERT DATA
        public static int Insert(Products_Suppliers pSupplier)
        {
            int result = -1;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Products_Suppliers (ProductId, SupplierId) OUTPUT INSERTED.ProductSupplierId values (@pId, @sId)";
                SqlParameter pIdPar = new SqlParameter("@pId", SqlDbType.Int);
                pIdPar.Value = pSupplier.ProductId;
                cmd.Parameters.Add(pIdPar);
                SqlParameter sIdPar = new SqlParameter("@sId", SqlDbType.Int);
                sIdPar.Value = pSupplier.SupplierId;
                cmd.Parameters.Add(sIdPar);
                Int32 newID = (Int32) cmd.ExecuteScalar();
                result = newID;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        throw new DuplicateKeyException(string.Format("Duplicate ID entry, please enter a different ID and try again {0}", pSupplier.SupplierId));
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
                con.Close();
            }
            return result;
        }
        // UPDATE DATA
        public static bool Update(Products_Suppliers oldPsupplier, Products_Suppliers newPsupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Products_Suppliers SET SupplierId = @newSid WHERE SupplierId = @oldSid AND ProductId = @oldPid";
                SqlParameter newSidPar = new SqlParameter("@newSid", SqlDbType.Int);
                newSidPar.Value = newPsupplier.SupplierId;
                cmd.Parameters.Add(newSidPar);
                SqlParameter oldSidPar = new SqlParameter("@oldSid", SqlDbType.Int);
                oldSidPar.Value = oldPsupplier.SupplierId;
                cmd.Parameters.Add(oldSidPar);
                SqlParameter oldPIdPar = new SqlParameter("@oldPid", SqlDbType.Int);
                oldPIdPar.Value = oldPsupplier.ProductId;
                cmd.Parameters.Add(oldPIdPar);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();

            }
            return result;
        }

        // DELETE DATA
        public static bool Delete(Products_Suppliers pSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Products_Suppliers WHERE ProductSupplierId = @id";
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                cmd.Parameters.Add(idPar);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        // DELETE 
        public static bool Delete(int prodId)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Products_Suppliers WHERE ProductId = @id";
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = prodId;
                cmd.Parameters.Add(idPar);

                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new ForiegnKeyException(string.Format("This suppler has products, cannot delete"));
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    // EXCEPTION ERROR HANDLE, DUPLICATE ID   
        public class DuplicateKeyException : Exception
        {
            public DuplicateKeyException(string message)
               : base(message)
            {
            }
        }
        // EXCEPTION ERROR HANDLE
        public class ForiegnKeyException : Exception
        {
            public ForiegnKeyException(string message)
               : base(message)
            {
            }
        }

    }
}

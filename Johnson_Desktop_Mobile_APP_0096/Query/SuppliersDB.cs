using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace Query
{
    // Create a class for supplierDB
    public class SuppliersDB
    {
        // create a list to store suppliers objects
        public static List<Suppliers> GetSuppliers()
        {
            Suppliers supplier = null;
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT SupplierID, SupName " +
                    "FROM Suppliers " +
                    "ORDER BY SupplierID;";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Suppliers> supplierList = new List<Suppliers>();
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string var1 = reader["SupplierID"].ToString();
                    supplier = new Suppliers((int)reader["SupplierID"], (string)reader["SupName"]);
                    supplierList.Add(supplier); // Add to return list
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
            return supplierList;
        }

        public static Suppliers GetSuppliers(int supID)
        {
            Suppliers supplier = null;
            SqlConnection conn = Connection.GetConnection();
            string query = "SELECT SupplierID, SupName " +
                    "FROM Suppliers " +
                    "WHERE SupplierId = @id;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", supID); 
            try
            { // use try and catch for command execution.
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    string var1 = reader["SupplierID"].ToString();
                    supplier = new Suppliers((int)reader["SupplierID"], (string)reader["SupName"]);
                    return supplier;
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
        // INSERT DATA
        public static bool Insert(Suppliers supplier)
        {
            bool result = false ;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Suppliers (SupplierId, SupName) values (@id, @name)";
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = supplier.SupplierId; 
                cmd.Parameters.Add(idPar);
                SqlParameter namePar = new SqlParameter("@name", SqlDbType.NVarChar);
                namePar.Value = supplier.SupName;
                cmd.Parameters.Add(namePar);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        throw new DuplicateKeyException(string.Format("Supplier ID already exist, please enter a different ID and try again {0}", supplier.SupplierId));
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
        public static bool Update(Suppliers oldSupplier, Suppliers newSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Suppliers SET SupplierId = @newId, SupName = @newName Where SupplierId = @oldID and SupName = @oldName";
                SqlParameter newIdPar = new SqlParameter("@newId", SqlDbType.Int);
                newIdPar.Value = newSupplier.SupplierId;
                cmd.Parameters.Add(newIdPar);
                SqlParameter newNamePar = new SqlParameter("@newName", SqlDbType.NVarChar);
                newNamePar.Value = newSupplier.SupName;
                cmd.Parameters.Add(newNamePar);
                SqlParameter oldIdPar = new SqlParameter("@oldId", SqlDbType.Int);
                oldIdPar.Value = oldSupplier.SupplierId;
                cmd.Parameters.Add(oldIdPar);
                SqlParameter oldNamePar = new SqlParameter("@oldName", SqlDbType.NVarChar);
                oldNamePar.Value = oldSupplier.SupName;
                cmd.Parameters.Add(oldNamePar);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new DuplicateKeyException(string.Format("Supplier ID already exist, please enter a different ID and try again {0}", newSupplier.SupplierId));
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
        // DELETE DATA
        public static bool Delete(Suppliers supplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierId = @id";
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = supplier.SupplierId;
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

        // DUPLICATE ID EXCEPTION HANDLE
        public class DuplicateKeyException : Exception
        {
            public DuplicateKeyException(string message)
               : base(message)
            {
            }
        }
        public class ForiegnKeyException : Exception
        {
            public ForiegnKeyException(string message)
               : base(message)
            {
            }
        }
    }
}


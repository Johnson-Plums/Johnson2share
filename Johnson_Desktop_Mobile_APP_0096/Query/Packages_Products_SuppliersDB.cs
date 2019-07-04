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
    // create a class for Packages_Products_SuppliersDB
    public class Packages_Products_SuppliersDB
    {// get suppliers as a list
        public static List<Packages_Products_Suppliers> GetSuppliers()
        {
            Packages_Products_Suppliers ppSupplier = null;

            SqlConnection conn = Connection.GetConnection();

            string query = "SELECT PackageId, ProductSupplierId " +
                    "FROM Packages_Products_Suppliers;";

            SqlCommand cmd = new SqlCommand(query, conn);
            List<Packages_Products_Suppliers> ppsList = new List<Packages_Products_Suppliers>();
            // use try and catch to execute command
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ppSupplier = new Packages_Products_Suppliers((int)reader["PackageId"], (int)reader["ProductSupplierId"]);
                    ppsList.Add(ppSupplier); 
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
            return ppsList;
        }
        //INSERT items
        public static bool Insert(Packages_Products_Suppliers ppSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId) values (@pId, @psId)";
                // insert the PackageId
                SqlParameter pIdPar = new SqlParameter("@pId", SqlDbType.Int);
                pIdPar.Value = ppSupplier.PackageId;
                cmd.Parameters.Add(pIdPar);
                // insert the ProductSupplierId 
                SqlParameter psIdPar = new SqlParameter("@psId", SqlDbType.Int);
                psIdPar.Value = ppSupplier.ProductSupplierId;
                cmd.Parameters.Add(psIdPar);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 2627:
                        throw new DuplicateKeyException(string.Format("Duplicate ID entry, please enter a different ID and try again {0}", ppSupplier.PackageId));
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
        //UPDATE DATA
        public static bool Update(Packages_Products_Suppliers oldPpSupplier, Packages_Products_Suppliers newPpSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "UPDATE Packages_Products_Suppliers SET PackageId = @newPid, ProductSupplierId = @newPsId Where PackageId = @oldPid and ProductSupplierId = @oldPsId";

                // new Package Id Paramater
                SqlParameter newPidPar = new SqlParameter("@newPid", SqlDbType.Int);
                newPidPar.Value = newPpSupplier.PackageId;
                cmd.Parameters.Add(newPidPar);

                // new ProductSupplierId Paramater
                SqlParameter newPsIdPar = new SqlParameter("@newPsId", SqlDbType.Int);
                newPsIdPar.Value = newPpSupplier.ProductSupplierId;
                cmd.Parameters.Add(newPsIdPar);

                // oldId Package Paramater
                SqlParameter oldIdPar = new SqlParameter("@oldPid", SqlDbType.Int);
                oldIdPar.Value = oldPpSupplier.PackageId;
                cmd.Parameters.Add(oldIdPar);

                // old ProductSupplierId Paramater
                SqlParameter oldNamePar = new SqlParameter("@oldPsId", SqlDbType.Int);
                oldNamePar.Value = oldPpSupplier.ProductSupplierId;
                cmd.Parameters.Add(oldNamePar);
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
        //DELET DATA
        public static bool Delete(Packages_Products_Suppliers ppSupplier)
        {
            bool result = false;
            SqlConnection con = Connection.GetConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "DELETE FROM Packages_Products_Suppliers WHERE PackageId = @id";

                // Primary Key Paramater
                SqlParameter idPar = new SqlParameter("@id", SqlDbType.Int);
                idPar.Value = ppSupplier.PackageId;
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
        // Exception error for duplicate input ID
        public class DuplicateKeyException : Exception
        {
            public DuplicateKeyException(string message)
               : base(message)
            {
            }
        }
    }
}


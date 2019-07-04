using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
namespace Query
{
  // create a PackagesDB class for CRUD operations
    public static class PackagesDB
    {
        // get the packages information as a list
        public static List<Packages> GetPackages()
        {
            // create a new list to store items as class packages objects
            List<Packages> packageList = new List<Packages>();

            string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission "
                + "FROM Packages;";
            using (SqlConnection connection = Connection.GetConnection())
            {
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    connection.Open();

                    SqlDataReader packageReader = selectCommand.ExecuteReader();

                    while (packageReader.Read())
                    {
                        Packages p = new Packages(); 
                        p.PackageId = (int)packageReader["PackageId"];
                        p.PkgName = (string)packageReader["PkgName"];

                        if (packageReader["PkgStartDate"] == DBNull.Value)
                        {
                            p.PkgStartDate = null;
                        }
                        else
                        {
                            p.PkgStartDate = (DateTime)(packageReader["PkgStartDate"]);
                        }

                        if (packageReader["PkgStartDate"] == DBNull.Value)
                        {
                            p.PkgEndDate = null;
                        }
                        else
                        {
                            p.PkgEndDate = (DateTime)packageReader["PkgEndDate"];
                        }

                        if (packageReader["PkgDesc"] == DBNull.Value)
                        {
                            p.PkgDesc = null;
                        }
                        else
                        {
                            p.PkgDesc = (string)packageReader["PkgDesc"];
                        }

                        p.PkgBasePrice = (decimal)packageReader["PkgBasePrice"];

                        if (packageReader["PkgAgencyCommission"] == DBNull.Value)
                        {
                            p.PkgAgencyCommission = null;
                        }
                        else
                        {
                            p.PkgAgencyCommission = (decimal)packageReader["PkgAgencyCommission"];
                        }

                        packageList.Add(p);
                    }
                }

                return packageList;
            }
        }

        // READ DATA
        public static Packages GetPackages(int packageID)
        {

            SqlConnection connection = Connection.GetConnection();
            string selectStatement
                = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission "
                + "FROM Packages "
                + "WHERE PackageID = @PackageID";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@PackageID", packageID);
            try
            {
                connection.Open();

                SqlDataReader packageReader = selectCommand.ExecuteReader(System.Data.CommandBehavior.SingleRow);

                if (packageReader.Read())
                {
                    Packages p = new Packages(); 
                    p.PackageId = (int)packageReader["PackageId"];
                    p.PkgName = (string)packageReader["PkgName"];

                    if (packageReader["PkgStartDate"] == DBNull.Value)
                    {
                        p.PkgStartDate = null;
                    }
                    else
                    {
                        p.PkgStartDate = (DateTime)(packageReader["PkgStartDate"]);
                    }

                    if (packageReader["PkgStartDate"] == DBNull.Value)
                    {
                        p.PkgEndDate = null;
                    }
                    else
                    {
                        p.PkgEndDate = (DateTime)packageReader["PkgEndDate"];
                    }

                    if (packageReader["PkgDesc"] == DBNull.Value)
                    {
                        p.PkgDesc = null;
                    }
                    else
                    {
                        p.PkgDesc = (string)packageReader["PkgDesc"];
                    }

                    p.PkgBasePrice = (decimal)packageReader["PkgBasePrice"];

                    if (packageReader["PkgAgencyCommission"] == DBNull.Value)
                    {
                        p.PkgAgencyCommission = null;
                    }
                    else
                    {
                        p.PkgAgencyCommission = (decimal)packageReader["PkgAgencyCommission"];
                    }
                    return p;
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

        //ADD DATA
        public static int AddPackage(Packages package)
        {
            SqlConnection connection = Connection.GetConnection();
            string insertStatment =
                "INSERT Packages "
                + "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencycommission) "
                + "VALUES (@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencycommission)";

            SqlCommand insertCommand = new SqlCommand(insertStatment, connection);
            insertCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement = "SELECT IDENT_CURRENT ('Packages') FROM Packages";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                int packageID = Convert.ToInt32(selectCommand.ExecuteScalar());
                return packageID;
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

        //DELETE DATA
        public static bool DeletePackage(Packages package)
        {
            SqlConnection connection = Connection.GetConnection();
            string deleteStatement =
                "DELETE FROM Packages "
                + "WHERE PackageId = @PackageId "
                + "AND PkgName = @PkgName "
                + "AND PkgStartDate = @PkgStartDate "
                + "AND PkgEndDate = @PkgEndDate "
                + "AND PkgDesc = @PkgDesc "
                + "AND PkgBasePrice = @PkgBasePrice "
                + "AND PkgAgencyCommission = @PkgAgencyCommission";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId", package.PackageId);
            deleteCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
        //UPDATE DATA
        public static bool UpdatePackage(Packages oldPackage, Packages newPackage)
        {
            SqlConnection connection = Connection.GetConnection();
            string updateStatement = "UPDATE Packages SET "
                + "PkgName = @NewPkgName, "
                + "PkgStartDate = @NewPkgStartDate, "
                + "PkgEndDate = @NewPkgEndDate, "
                + "PkgDesc = @NewPkgDesc, "
                + "PkgBasePrice = @NewPkgBasePrice, "
                + "PkgAgencyCommission = @NewPkgAgencyCommission " 
                + "WHERE PackageID = @OldPackageID ";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewPkgName", newPackage.PkgName);
            updateCommand.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@NewPkgEndDate", newPackage.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDesc);
            updateCommand.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommission);
            updateCommand.Parameters.AddWithValue("@OldPackageId", oldPackage.PackageId);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
    }
}


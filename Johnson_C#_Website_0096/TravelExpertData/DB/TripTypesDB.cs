using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.datadefinitions;

namespace TravelExpertData.DBactions
{//Author: Josh, Wei, Johnson
 //Time: May 23, 2019
    public class TripTypesDB
    {
        public static List<TripTypes> GetTripTypes()
        {
            List<TripTypes> tripTypeList = new List<TripTypes>();
            TripTypes tripType; 
            SqlConnection connection = UnversalDBControls.GetConnection();
            string selectStatement = "SELECT TripTypeId, TTName " +
                                     "FROM TripTypes ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    tripType = new TripTypes();
                    tripType.TripTypeId = dr["TripTypeId"].ToString();
                    tripType.TTName = dr["TTName"].ToString();
                    tripTypeList.Add(tripType);
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
            return tripTypeList;
        }
    }
}

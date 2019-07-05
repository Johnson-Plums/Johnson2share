﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.datadefinitions;

namespace TravelExpertData.DBactions
{
    //Author: Josh, Wei, Johnson
    //Time: May 23, 2019
    // AgentsDB contains all of the sql statements 
    //responsible for data manipulation for the Agents table
    public static class AgentsDB
    {
        // Method responsible for getting Agents in the Agents table 
        //according to the passed Agency Id
        public static List<Agents> GetAgents(int AgencyId)
        {
            List<Agents> agenstlist = new List<Agents>();
            Agents agents;
            SqlConnection connection = UnversalDBControls.GetConnection();
            string selectStatement = "SELECT AgtFirstName, AgtLastName, AgtBusPhone, AgtEmail, AgtPosition " +
                                     "FROM Agents " +
                                     "WHERE AgencyId = @AgencyId ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@AgencyId", AgencyId);
            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    agents = new Agents();
                    //agents.ProdName = dr["ProdName"].ToString();
                    agents.AgtFirstName = dr["AgtFirstName"].ToString();
                    agents.AgtLastName = dr["AgtLastName"].ToString();
                    agents.AgtBusPhone = dr["AgtBusPhone"].ToString();
                    agents.AgtEmail = dr["AgtEmail"].ToString();
                    agents.AgtPosition = dr["AgtPosition"].ToString();
                    agenstlist.Add(agents);
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
            return agenstlist;
        }
    }
}

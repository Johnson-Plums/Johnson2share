using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Query
{
    // create a data Gridview Database class
    public class DataGridDB
    {
       
        private static SqlDataAdapter sqlDa; // data adapter
        private static DataTable dtbl; // data table
        private static SqlCommandBuilder commandBuilder; // build command

        private static SqlConnection con = Connection.GetConnection();

        //create method to show data in grid view
        public static void GetDGData(string query, DataGridView dgvName, BindingSource bsName)
        {
            try
            { // open connection
                con.Open();
                sqlDa = new SqlDataAdapter(query, con); 
                dtbl = new DataTable(); // create a table for the datasource
                // fill the created sql data adapter from the database table as source 
                sqlDa.Fill(dtbl); 

                bsName.DataSource = dtbl; //add table querried in datagrid view
                dgvName.Columns[0].ReadOnly = true; //prevent user from modifiying first column which is id
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close(); // close connection
            }
        }

        //create a method to delete data from datagridview
        public static void DeleteDGData(string dbTableName, string NameId, DataGridView dgvName)
        {
            DataGridViewRow row = dgvName.CurrentCell.OwningRow; 
            //get data row by row and pass value to string save as value
            string value = row.Cells[NameId].Value.ToString(); 
            // show dialog message
            DialogResult result = MessageBox.Show("Do you really want to delete the record. ", "Confirm Delete Record.", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            string deleteStmt = String.Format("Delete from {0} where {1} = {2}", dbTableName, NameId, value);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand comm = new SqlCommand(deleteStmt, con);
                    comm.ExecuteNonQuery();
                }
                catch(DBConcurrencyException)
                {
                    MessageBox.Show("Another user has updated or deleted the record. Please refresh the table", "Unable to perform command", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                } 
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //create a method to save edited data from datagridview
        public static void SaveDGData(BindingSource bsName)
        {
            DialogResult result = MessageBox.Show("Do you really want to update database? ", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    commandBuilder = new SqlCommandBuilder(sqlDa);
                    bsName.EndEdit();
                    sqlDa.Update(dtbl);
                    MessageBox.Show("Update successful");
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("Another user has updated or deleted the record. Please refresh the table", "Unable to perform command", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}

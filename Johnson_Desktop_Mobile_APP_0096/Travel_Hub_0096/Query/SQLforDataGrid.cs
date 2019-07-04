using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query
{
    // CREATE A CLASS FOR SQL QUERY
    public class SQLforDataGrid
    {
        private static string query; 
        // CREATE A METHOND TO generate sql querries
        public static string SqlQuery(string tableName, string colNames, string orderbyColName)
        {
            query = string.Format("SELECT {0} FROM {1} ORDER BY {2}", colNames, tableName, orderbyColName);
            return query;
        }
    }
}

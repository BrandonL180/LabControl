using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace login.Data
{
    public class DataBase
    {
         
        public SqlConnection DatabaseConnection(string actionToPerform) {

            string connectionString = "Data Source=BRANDONLOAIZA;Initial Catalog=LabControl01;Persist Security Info=True;User ID=sa";
          
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                if (actionToPerform.Equals("open"))
                {
                    sqlConnection.Open();
                }
                else
                {
                    sqlConnection.Close();
                }
            }
            catch(SqlException sqlException) {
                Console.WriteLine("Database error: " + sqlException.ToString());
            }

            return sqlConnection;
        }
    }
}
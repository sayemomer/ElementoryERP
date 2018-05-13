using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERPRepository
{
    class DatabaseConnection
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnection()
        {

            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\ElementoryERP\ERPRepository\ERPDB.mdf;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(connectionString);
        }
        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }
        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
             return myCommand.ExecuteReader();
           
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteNonQuery();
        }

    }
}

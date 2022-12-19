using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FilmsUI
{
    public class Database
    {
        private static string _connectionString { get; set; }
        public static SqlConnection _sqlConnection { get; set; }

        public static void SetDataSource(string dataSource)
        {
            _connectionString = @$"Data Source={dataSource};Initial Catalog=Films;Integrated Security=True";
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                OpenConnection();
                CloseConnection();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }
        
        public static void OpenConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
        }

        public static void CloseConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }
    }
}

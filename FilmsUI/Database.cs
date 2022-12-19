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
        public static readonly string _connectionString = @$"Data Source=BUGURT\SQLEXPRESS;Initial Catalog=Films;Integrated Security=True";
        public static readonly SqlConnection _sqlConnection = new SqlConnection(_connectionString);

        public void OpenConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
                _sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
                _sqlConnection.Close();
        }
    }
}

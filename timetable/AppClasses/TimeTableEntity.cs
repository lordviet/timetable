using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace timetable.AppClasses
{
    abstract class TimeTableEntity
    {
        public static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        public DataTable Select(string tableName)
        {
            var connection = new SqlConnection(connectionString);
            var dt = new DataTable();

            try
            {
                var query = $"SELECT * FROM {tableName}";
                var cmd = new SqlCommand(query, connection);

                // Creating SQL Data Adapter using cmd
                var adapter = new SqlDataAdapter(cmd);
                connection.Open();

                // Filling the data table
                adapter.Fill(dt);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public bool Delete(string tableName, string idName, int id)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to delete the data
                var query = $"DELETE FROM {tableName} WHERE {idName}=@{idName}";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue($"@{idName}", id);

                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0 ? true : false;
            }
            finally
            {
                connection.Close();
            }

            return isSuccess;
        }
    }
}

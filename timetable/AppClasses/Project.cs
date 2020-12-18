using System;
using System.Configuration;
using System.Data.SqlClient;

namespace timetable.AppClasses
{
    class Project : TimeTableEntity
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public DateTime ProjectBegin { get; set; }

        public DateTime ProjectEnd { get; set; }

        public string ProjectDescription { get; set; }

        public char ProjectStatus { get; set; }

        public int ProjectMaxHours { get; set; }

        static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        public bool Insert(Project ClassProject)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO PROJECT (PROJECT_NAME, PROJECT_BEGIN, PROJECT_END, PROJECT_DESCRIPTION, PROJECT_STATUS, PROJECT_MAXHOURS) " +
                            "VALUES(@PROJECT_NAME, @PROJECT_BEGIN, @PROJECT_END, @PROJECT_DESCRIPTION, @PROJECT_STATUS, @PROJECT_MAXHOURS)";

                var cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue("@PROJECT_ID", ClassProject.ProjectId);
                cmd.Parameters.AddWithValue("@PROJECT_NAME", ClassProject.ProjectName);
                cmd.Parameters.AddWithValue("@PROJECT_BEGIN", ClassProject.ProjectBegin);
                cmd.Parameters.AddWithValue("@PROJECT_END", ClassProject.ProjectEnd);
                cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", ClassProject.ProjectDescription);
                cmd.Parameters.AddWithValue("@PROJECT_STATUS", ClassProject.ProjectStatus);
                cmd.Parameters.AddWithValue("@PROJECT_MAXHOURS", ClassProject.ProjectMaxHours);

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

        // Updating the database
        public bool Update(Project ClassProject)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE PROJECT SET PROJECT_NAME=@PROJECT_NAME, PROJECT_BEGIN=@PROJECT_BEGIN, PROJECT_END=@PROJECT_END, PROJECT_DESCRIPTION=@PROJECT_DESCRIPTION, PROJECT_STATUS=@PROJECT_STATUS, PROJECT_MAXHOURS=@PROJECT_MAXHOURS " +
                            "WHERE PROJECT_ID=@PROJECT_ID";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@PROJECT_ID", ClassProject.ProjectId);
                cmd.Parameters.AddWithValue("@PROJECT_NAME", ClassProject.ProjectName);
                cmd.Parameters.AddWithValue("@PROJECT_BEGIN", ClassProject.ProjectBegin);
                cmd.Parameters.AddWithValue("@PROJECT_END", ClassProject.ProjectEnd);
                cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", ClassProject.ProjectDescription);
                cmd.Parameters.AddWithValue("@PROJECT_STATUS", ClassProject.ProjectStatus);
                cmd.Parameters.AddWithValue("@PROJECT_MAXHOURS", ClassProject.ProjectMaxHours);

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
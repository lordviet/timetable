using System;
using System.Configuration;
using System.Data.SqlClient;

namespace timetable.AppClasses
{
    class Employee : TimeTableEntity
    {
        public int EmployeeId { get; set; }

        public string EmployeeEgn { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeePosition { get; set; }

        public DateTime EmployeeHireDate { get; set; }

        static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        public bool Insert(Employee ClassEmployee)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // SQL Query to Insert the data
                var query = "INSERT INTO EMPLOYEES (EMPLOYEE_EGN, EMPLOYEE_NAME, EMPLOYEE_SURNAME, EMPLOYEE_LASTNAME, EMPLOYEE_POSITION, EMPLOYEE_HIREDATE) " +
                            "VALUES(@EMPLOYEE_EGN, @EMPLOYEE_NAME, @EMPLOYEE_SURNAME, @EMPLOYEE_LASTNAME, @EMPLOYEE_POSITION, @EMPLOYEE_HIREDATE)";

                var cmd = new SqlCommand(query, connection);

                //cmd.Parameters.AddWithValue("@EMPLOYEE_ID", ClassEmployee.EmployeeId);
                cmd.Parameters.AddWithValue("@EMPLOYEE_EGN", ClassEmployee.EmployeeEgn);
                cmd.Parameters.AddWithValue("@EMPLOYEE_NAME", ClassEmployee.EmployeeName);
                cmd.Parameters.AddWithValue("@EMPLOYEE_SURNAME", ClassEmployee.EmployeeSurname);
                cmd.Parameters.AddWithValue("@EMPLOYEE_LASTNAME", ClassEmployee.EmployeeLastName);
                cmd.Parameters.AddWithValue("@EMPLOYEE_POSITION", ClassEmployee.EmployeePosition);
                cmd.Parameters.AddWithValue("@EMPLOYEE_HIREDATE", ClassEmployee.EmployeeHireDate);

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
        public bool Update(Employee ClassEmployee)
        {
            var isSuccess = false;
            var connection = new SqlConnection(connectionString);

            try
            {
                // Query to update the data
                var query = "UPDATE EMPLOYEES SET EMPLOYEE_EGN=@EMPLOYEE_EGN, EMPLOYEE_NAME=@EMPLOYEE_NAME, EMPLOYEE_SURNAME=@EMPLOYEE_SURNAME, EMPLOYEE_LASTNAME=@EMPLOYEE_LASTNAME, EMPLOYEE_POSITION=@EMPLOYEE_POSITION, EMPLOYEE_HIREDATE=@EMPLOYEE_HIREDATE " +
                            "WHERE EMPLOYEE_ID=@EMPLOYEE_ID";

                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@EMPLOYEE_ID", ClassEmployee.EmployeeId);
                cmd.Parameters.AddWithValue("@EMPLOYEE_EGN", ClassEmployee.EmployeeEgn);
                cmd.Parameters.AddWithValue("@EMPLOYEE_NAME", ClassEmployee.EmployeeName);
                cmd.Parameters.AddWithValue("@EMPLOYEE_SURNAME", ClassEmployee.EmployeeSurname);
                cmd.Parameters.AddWithValue("@EMPLOYEE_LASTNAME", ClassEmployee.EmployeeLastName);
                cmd.Parameters.AddWithValue("@EMPLOYEE_POSITION", ClassEmployee.EmployeePosition);
                cmd.Parameters.AddWithValue("@EMPLOYEE_HIREDATE", ClassEmployee.EmployeeHireDate);

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

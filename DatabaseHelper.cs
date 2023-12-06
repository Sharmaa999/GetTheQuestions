using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication7
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=MUM-LAP-700373\\SQLEXPRESS01;Initial Catalog=SchoolDatabase;Integrated Security=True";

        public static void CreateUser(string username, string password, string userType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO UsersS (UserName, Password, Role) VALUES (@Username, @Password, @Role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", userType);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool ValidateUser(string username, string password, string userType)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM UsersS WHERE UserName = @Username AND Password = @Password AND Role = @Role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", userType);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;

namespace LibraryManagementSystem
{
    internal class UserService
    {
        private string connectionString;

        public UserService(string connString)
        {
            connectionString = connString;
        }

        public bool Login(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password"; // Secure this with hashing in real applications
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Note: Use hashed password

                    MySqlDataReader reader = cmd.ExecuteReader();

                    return reader.Read(); // Returns true if a matching user is found
                }
                catch (Exception ex)
                {
                    // Log exception (not shown here for simplicity)
                    throw new Exception("Database error", ex);
                }
            }
        }
    }
}

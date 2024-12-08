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

            this.CreateTable();
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

        private void CreateTable()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to create the issued_books table with foreign key constraints
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS users (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            username varchar(255) NOT NULL,
                            password varchar(255) NOT NULL
                        );
                    ";

                    // Execute the table creation query
                    MySqlCommand cmd = new MySqlCommand(createTableQuery, conn);
                    cmd.ExecuteNonQuery();

                    // SQL query to insert the admin user if it doesn't already exist
                    string insertAdminQuery = @"
                        INSERT INTO users (username, password)
                        SELECT 'admin', 'admin'
                        WHERE NOT EXISTS (
                            SELECT 1 FROM users WHERE username = 'admin'
                        );
                    ";

                    // Execute the insert query
                    cmd = new MySqlCommand(insertAdminQuery, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle and log the exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }
    }
}

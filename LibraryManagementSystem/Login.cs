using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtBxUsername.Text;
            string password = this.txBxPassword.Text;

            loginUser(username, password);
        }

        private void loginUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password"; // Adjust your table and column names as necessary
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // Note: Consider hashing passwords in a real application

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login successful, retrieve user details if needed
                        string name = reader["username"].ToString(); // or any other relevant user information
                        MessageBox.Show($"Login successful! Welcome, {name}.");
                    }
                    else
                    {
                        // No matching user found
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}

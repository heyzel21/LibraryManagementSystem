using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";
        private UserService userService;

        public Login()
        {
            InitializeComponent();
            userService = new UserService(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtBxUsername.Text;
            string password = this.txBxPassword.Text;

            try
            {
                if (userService.Login(username, password))
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to the next form or functionality
                }
                else
                {
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

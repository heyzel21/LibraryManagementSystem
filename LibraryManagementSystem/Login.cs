using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        private Dashboard dashboard;
        private UserService userService;

        private string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        public Login()
        {
            InitializeComponent();
            userService = new UserService(connectionString);
            dashboard = new Dashboard();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            try
            {
                if (userService.Login(username, password))
                {
                    MessageBox.Show("Login successful!");

                    this.Hide();
                    dashboard.Show();
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

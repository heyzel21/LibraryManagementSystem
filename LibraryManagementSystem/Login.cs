using System;
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dashboard = new Dashboard(this);
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

                    this.txtUsername.ResetText();
                    this.txtPassword.ResetText();
                    this.txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

                    this.Hide();
                    this.dashboard.Show();
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

        private void ShowHidePasswordButton_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.UseSystemPasswordChar)
            {
                this.txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
        }
    }
}

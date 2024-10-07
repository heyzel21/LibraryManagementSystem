using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtBxUsername.Text;
            string password = this.txBxPassword.Text;

            if (username == "admin" && password == "admin")
            {
                Console.WriteLine("Login succesful");
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

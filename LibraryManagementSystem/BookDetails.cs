using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookDetails : Form
    {
        public BookDetails(Book book)
        {
            InitializeComponent();
            this.PopulateData(book);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateData(Book book)
        {
            this.idPlaceholder.Text = book.id.ToString();
            this.titlePlaceholder.Text = book.title;
            this.authorPlaceholder.Text = book.author;
            this.publishedPlaceholder.Text = book.publishedDate.Date.ToString();
            this.quantityPlaceholder.Text = book.quantity.ToString();
        }
    }
}

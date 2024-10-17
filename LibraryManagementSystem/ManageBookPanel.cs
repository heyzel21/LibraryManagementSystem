using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManageBookPanel : UserControl
    {
        private BookService bookService;

        private string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        public ManageBookPanel()
        {
            InitializeComponent();
            this.bookService = new BookService(connectionString);
        }

        private void ManageBookPanel_Load(object sender, EventArgs e)
        {
            this.RefreshBookDataGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Book newBook = new Book
            {
                title = "The Great Gatsby",
                author = "F. Scott Fitzgerald",
                publishedDate = new DateTime(2000, 10, 17),
                quantity = 10
            };

            this.bookService.Add(newBook);
            this.RefreshBookDataGridView();
        }

        private void RefreshBookDataGridView()
        {
            booksDataGridView.DataSource = this.bookService.List();
        }
    }
}

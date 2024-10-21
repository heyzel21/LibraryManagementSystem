using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManageBookPanel : UserControl
    {
        private readonly BookService bookService;

        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        private int selectedId = 0;

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
            try
            {
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                string publishedDate = publishedTextBox.Text;
                int quantity = Int32.Parse(quantityTextBox.Text);

                Book newBook = new Book(title, author, new DateTime(2000, 10, 17), quantity);

                this.bookService.Add(newBook);
                this.RefreshBookDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Please complete the form.");
            }
        }

        private void RefreshBookDataGridView()
        {
            booksDataGridView.DataSource = this.bookService.List();
            this.ResetForm();
        }

        private void booksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.booksDataGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            string title = row.Cells["title"].Value.ToString();
            string author = row.Cells["author"].Value.ToString();
            string publishedDate = row.Cells["publishedDate"].Value.ToString();
            string quantity = row.Cells["quantity"].Value.ToString();

            this.selectedId = id;
            titleTextBox.Text = title;
            authorTextBox.Text = author;
            publishedTextBox.Text = publishedDate;
            quantityTextBox.Text = quantity;

            this.deleteButton.Enabled = true;
            this.updateButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.bookService.Delete(this.selectedId);
            this.RefreshBookDataGridView();
        }
        private void ResetForm()
        {
            this.selectedId = 0;
            this.titleTextBox.Text = "";
            this.authorTextBox.Text = "";
            this.publishedTextBox.Text = "";
            this.quantityTextBox.Text = "";

            this.deleteButton.Enabled = false;
            this.updateButton.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = selectedId;
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                string publishedDate = publishedTextBox.Text;
                int quantity = Int32.Parse(quantityTextBox.Text);

                Book newBook = new Book(id, title, author, new DateTime(2000, 10, 17), quantity);

                this.bookService.Update(newBook);
                this.RefreshBookDataGridView();
                MessageBox.Show("Updated succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

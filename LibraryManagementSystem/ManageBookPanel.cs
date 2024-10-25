using Google.Protobuf.WellKnownTypes;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManageBookPanel : UserControl
    {
        private readonly BookService bookService;
        private readonly PromptService promptService;

        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        private int selectedId = 0;

        public ManageBookPanel()
        {
            InitializeComponent();

            this.bookService = new BookService(connectionString);
            this.promptService = new PromptService();
        }

        private void ManageBookPanel_Load(object sender, EventArgs e)
        {
            this.RefreshBookDataGridView();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                DateTime datePublished = dateTimePickerPublished.Value.Date;
                int quantity = Int32.Parse(quantityTextBox.Text);

                Book newBook = new Book(title, author, datePublished, quantity);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to add this book details?");
                if (isConfirmed)
                {
                    this.bookService.Add(newBook);
                    this.RefreshBookDataGridView();
                    MessageBox.Show("Book added succesfully");
                }
                else
                {
                    this.ResetForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = selectedId;
                string title = titleTextBox.Text;
                string author = authorTextBox.Text;
                DateTime datePublished = dateTimePickerPublished.Value.Date;
                int quantity = Int32.Parse(quantityTextBox.Text);

                Book newBook = new Book(id, title, author, datePublished, quantity);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to update this book details?");
                if (isConfirmed)
                {
                    this.bookService.Update(newBook);
                    this.RefreshBookDataGridView();
                    MessageBox.Show("Book updated succesfully");
                }
                else
                {
                    this.ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool isConfirmed = this.promptService.ShowConfirmation("Do you want to delete this book details?");

            if (isConfirmed)
            {
                this.bookService.Delete(this.selectedId);
                this.RefreshBookDataGridView();
            } else
            {
                this.ResetForm();
            }
            
        }

        private void RefreshBookDataGridView()
        {
            booksDataGridView.DataSource = this.bookService.List();
            this.ResetForm();
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.booksDataGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            string title = row.Cells["title"].Value.ToString();
            string author = row.Cells["author"].Value.ToString();
            string publishedDate = row.Cells["publishedDate"].Value.ToString();
            string quantity = row.Cells["quantity"].Value.ToString();

            this.selectedId = id;
            this.titleTextBox.Text = title;
            this.authorTextBox.Text = author;
            this.quantityTextBox.Text = quantity;
            this.dateTimePickerPublished.Value = DateTime.Parse(publishedDate?.ToString());

            this.deleteButton.Enabled = true;
            this.updateButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }
        
        private void ResetForm()
        {
            this.selectedId = 0;
            this.titleTextBox.Text = "";
            this.authorTextBox.Text = "";
            this.quantityTextBox.Text = "";
            this.dateTimePickerPublished.ResetText();

            this.deleteButton.Enabled = false;
            this.updateButton.Enabled = false;
        }
    }
}

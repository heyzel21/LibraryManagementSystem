using Google.Protobuf.WellKnownTypes;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueReturnBookPanel : UserControl
    {
        private readonly IssueReturnBookService issueReturnBookService;
        private readonly PromptService promptService;

        private StudentDetails studentDetails;
        private BookDetails bookDetails;

        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        private int selectedId = 0;
        private readonly int noOfDaysToReturnRule = 3;

        public IssueReturnBookPanel()
        {
            InitializeComponent();

            this.issueReturnBookService = new IssueReturnBookService(connectionString);
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
                int studentId = Convert.ToInt32(Math.Round(this.studentIdNumericUpDown.Value, 0));
                int bookId = Convert.ToInt32(Math.Round(this.bookIdNumericUpDown.Value, 0));
                DateTime dateBorrow = DateTime.Now;

                if (studentId == 0 || bookId == 0)
                {
                    return;
                }

                IssueReturnBook newIssueReturnBook = new IssueReturnBook(studentId, bookId, dateBorrow);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to record this details?");
                if (isConfirmed)
                {
                    this.issueReturnBookService.Add(newIssueReturnBook);
                    this.RefreshBookDataGridView();

                    MessageBox.Show("Note: The book is issued today at " + DateTime.Now.Date + ". Book should be returned within " + this.noOfDaysToReturnRule + " days.");
                    MessageBox.Show("Record added succesfully");
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
            //try
            //{
            //    int id = selectedId;
            //    string title = titleTextBox.Text;
            //    string author = authorTextBox.Text;
            //    DateTime datePublished = dateTimePickerPublished.Value.Date;
            //    int quantity = Int32.Parse(quantityTextBox.Text);

            //    Book newBook = new Book(id, title, author, datePublished, quantity);

            //    bool isConfirmed = this.promptService.ShowConfirmation("Do you want to update this book details?");
            //    if (isConfirmed)
            //    {
            //        this.bookService.Update(newBook);
            //        this.RefreshBookDataGridView();
            //        MessageBox.Show("Book updated succesfully");
            //    }
            //    else
            //    {
            //        this.ResetForm();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //bool isConfirmed = this.promptService.ShowConfirmation("Do you want to delete this book details?");

            //if (isConfirmed)
            //{
            //    this.bookService.Delete(this.selectedId);
            //    this.RefreshBookDataGridView();
            //    MessageBox.Show("Book deleted succesfully");
            //} else
            //{
            //    this.ResetForm();
            //}
            
        }

        private void RefreshBookDataGridView()
        {
            //booksDataGridView.DataSource = this.bookService.List();
            //this.ResetForm();
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) { return; }

            //DataGridViewRow row = this.booksDataGridView.Rows[e.RowIndex];
            //int id = Int32.Parse(row.Cells["id"].Value.ToString());
            //string title = row.Cells["title"].Value.ToString();
            //string author = row.Cells["author"].Value.ToString();
            //string publishedDate = row.Cells["publishedDate"].Value.ToString();
            //string quantity = row.Cells["quantity"].Value.ToString();

            //this.selectedId = id;
            //this.titleTextBox.Text = title;
            //this.authorTextBox.Text = author;
            //this.quantityTextBox.Text = quantity;
            //this.dateTimePickerPublished.Value = DateTime.Parse(publishedDate?.ToString());

            //this.deleteButton.Enabled = true;
            //this.updateButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //this.ResetForm();
        }
        
        private void ResetForm()
        {
            //this.selectedId = 0;
            //this.titleTextBox.Text = "";
            //this.authorTextBox.Text = "";
            //this.quantityTextBox.Text = "";
            //this.dateTimePickerPublished.ResetText();

            //this.deleteButton.Enabled = false;
            //this.updateButton.Enabled = false;
        }

        private void ViewStudentButton_Click(object sender, EventArgs e)
        {
            studentDetails = new StudentDetails();
            studentDetails.Show();
        }

        private void ViewBookButon_Click(object sender, EventArgs e)
        {
            bookDetails = new BookDetails();
            bookDetails.Show();
        }
    }
}

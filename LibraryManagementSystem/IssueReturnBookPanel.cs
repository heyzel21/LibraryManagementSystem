using Google.Protobuf.WellKnownTypes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueReturnBookPanel : UserControl
    {
        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";
        private readonly PromptService promptService;
        private readonly IssueReturnBookService issueReturnBookService;
        private readonly StudentService studentService;
        private readonly BookService bookService;

        private StudentDetails studentDetails;
        private BookDetails bookDetails;

        private int selectedId = 0;
        private readonly int noOfDaysToReturnRule = 3;

        public IssueReturnBookPanel()
        {
            InitializeComponent();

            this.promptService = new PromptService();

            this.issueReturnBookService = new IssueReturnBookService(connectionString);
            this.studentService = new StudentService(connectionString);
            this.bookService = new BookService(connectionString);
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
                DateTime dateReturn = dateBorrow.AddDays(this.noOfDaysToReturnRule);

                if (studentId == 0 || bookId == 0)
                {
                    return;
                }

                IssueReturnBook newIssueReturnBook = new IssueReturnBook(studentId, bookId, dateBorrow, dateReturn);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to record this details?");
                if (isConfirmed)
                {
                    this.issueReturnBookService.Add(newIssueReturnBook);
                    this.RefreshBookDataGridView();

                    MessageBox.Show("Note: The book is issued today at " + dateBorrow.ToString("MMMM d, yyyy") + ". Book should be returned by " + dateReturn.ToString("MMMM d, yyyy") + ".");
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool isConfirmed = this.promptService.ShowConfirmation("Do you want to delete this record?");

            if (isConfirmed)
            {
                this.issueReturnBookService.Delete(this.selectedId);
                this.RefreshBookDataGridView();
                MessageBox.Show("Record deleted succesfully");
            }
            else
            {
                this.ResetForm();
            }

        }

        private void RefreshBookDataGridView()
        {
            issueReturnBooksDataGridView.DataSource = this.issueReturnBookService.List();
            issueReturnBooksDataGridView.CellFormatting += DataGridView1_CellFormatting;
            this.ResetForm();
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if this is the date_return column
            if (issueReturnBooksDataGridView.Columns[e.ColumnIndex].Name == "dateReturn" && e.Value != null)
            {
                DateTime now = DateTime.Now;
                TimeSpan difference = Convert.ToDateTime(e.Value).Date - now.Date;

                if (difference.Days < 0)
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.issueReturnBooksDataGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            int student_id = Int32.Parse(row.Cells["studentId"].Value.ToString());
            int book_id = Int32.Parse(row.Cells["bookId"].Value.ToString());

            this.selectedId = id;
            this.studentIdNumericUpDown.Value = student_id;
            this.bookIdNumericUpDown.Value = book_id;

            this.deleteButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }
        
        private void ResetForm()
        {
            this.selectedId = 0;
            this.studentIdNumericUpDown.Value = 0;
            this.bookIdNumericUpDown.Value = 0;

            this.deleteButton.Enabled = false;
        }

        private void ViewStudentButton_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(Math.Round(this.studentIdNumericUpDown.Value, 0));
            Student student = this.studentService.GetByStudentId(studentId);

            if (student.id == 0)
            {;
                MessageBox.Show("Sorry, this student ID number does not exist.");
                return;
            }

            studentDetails = new StudentDetails(student);
            studentDetails.Show();
        }

        private void ViewBookButon_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(Math.Round(this.bookIdNumericUpDown.Value, 0));
            Book book = this.bookService.GetById(bookId);

            if (book.id == 0)
            {
                MessageBox.Show("Sorry, this book ID number does not exist.");
                return;
            }

            bookDetails = new BookDetails(book);
            bookDetails.Show();
        }
    }
}

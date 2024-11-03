using Google.Protobuf.WellKnownTypes;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueReturnBookPanel : UserControl
    {
        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";
        private readonly PromptService promptService;
        private readonly IssueReturnBookService issueReturnBookService;
        private readonly StudentService studentService;

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
            this.ResetForm();
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.issueReturnBooksDataGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            int student_id = Int32.Parse(row.Cells["student_id"].Value.ToString());
            int book_id = Int32.Parse(row.Cells["book_id"].Value.ToString());

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
            bookDetails = new BookDetails();
            bookDetails.Show();
        }
    }
}

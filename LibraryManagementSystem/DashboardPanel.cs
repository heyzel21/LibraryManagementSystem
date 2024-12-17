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
    public partial class DashboardPanel : UserControl
    {
        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";
        private BookService bookService;
        private StudentService studentService;
        private IssueReturnBookService issueReturnBookService;

        public DashboardPanel()
        {
            InitializeComponent();

            this.bookService = new BookService(connectionString);
            this.studentService = new StudentService(connectionString);
            this.issueReturnBookService = new IssueReturnBookService(connectionString);

            this.PopulateData();
        }

        public void PopulateData()
        {
            try
            {
                int studentCount = this.studentService.List().Count;
                int booksCount = this.bookService.List().Count;
                int issuedBooksCount = this.bookService.List().Count;
                int studentsPenaltyCount = this.issueReturnBookService.ListDue().Count;

                this.noOfStudentsPlaceholder.Text = studentCount.ToString();
                this.numberOfBooksPlaceholder.Text = booksCount.ToString();
                this.issuedBooksPlaceholder.Text = issuedBooksCount.ToString();
                this.noOfstudentPenaltyPlaceholder.Text = studentsPenaltyCount.ToString();

                this.UpdateBarPanel(this.studentsBarPanel, this.studentPercentageLabel, studentCount);
                this.UpdateBarPanel(this.booksBarPanel, this.booksPercentageLabel, booksCount);
                this.UpdateBarPanel(this.issuedBooksBarPanel, this.issuedBooksPercentageLabel, issuedBooksCount);
                this.UpdateBarPanel(this.penaltiesBarPanel, this.penaltyPercentageLabel, studentsPenaltyCount);

                this.CountPendingAndPaid();
            }
            catch (Exception ex) 
            {
                Console.Write(ex.ToString());
            }
        }

        private void UpdateBarPanel(Panel panelBar, Label percentageLabel, int quantity)
        {
            float max = 1000;
            float percentage = (quantity / max) * 100;
            int fill = (int)(600 * (percentage / 100));

            percentageLabel.Text = Math.Round(percentage).ToString() + "%";
            panelBar.Size = new System.Drawing.Size(fill, 29);
        }

        private void CountPendingAndPaid()
        {
            int penaltyPaid = 0;
            int penaltyPending = 0;

            for (int i = 0; i < this.issueReturnBookService.ListDue().Count; i++)
            {
                if (this.issueReturnBookService.ListDue()[i].IsPenaltyPaid == "Yes")
                {
                    penaltyPaid++;
                }
                else
                {
                    penaltyPending++;
                }
            }

            this.paidPlaceholder.Text = penaltyPaid.ToString();
            this.unpaidPlaceholder.Text = penaltyPending.ToString();
        }
    }
}

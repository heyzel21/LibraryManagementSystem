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
                this.noOfStudentsPlaceholder.Text = this.studentService.List().Count.ToString();
                this.numberOfBooksPlaceholder.Text = this.bookService.List().Count.ToString();
                this.issuedBooksPlaceholder.Text = this.issueReturnBookService.List().Count.ToString();
                this.noOfstudentPenaltyPlaceholder.Text = this.issueReturnBookService.ListDue().Count.ToString();

                this.CountPendingAndPaid();
            }
            catch (Exception ex) 
            {
                Console.Write(ex.ToString());
            }

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

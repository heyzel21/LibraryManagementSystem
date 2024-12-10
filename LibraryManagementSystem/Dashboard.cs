using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";
        private BookService bookService;
        public Dashboard()
        {
            InitializeComponent();
            this.HidePanels();
            this.dashboardPanel.Visible = true;

            this.bookService = new BookService(connectionString);
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.dashboardPanel.PopulateData();
            this.dashboardPanel.Visible = true;
        }
        private void ManageBooksBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.manageBookPanel.Visible = true;
        }

        private void ManageStudentsBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.manageStudentPanel.Visible = true;
        }

        private void IssueReturnBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.issueReturnBookPanel.RefreshBookDataGridView();
            this.issueReturnBookPanel.Visible = true;
        }

        private void ManagePenaltyBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.managePenaltyPanel.RefreshBookDataGridView();
            this.managePenaltyPanel.Visible = true;
        }

        private void HidePanels()
        {
            this.dashboardPanel.Visible = false;
            this.manageBookPanel.Visible = false;
            this.manageStudentPanel.Visible = false;
            this.issueReturnBookPanel.Visible = false;
        }
    }
}

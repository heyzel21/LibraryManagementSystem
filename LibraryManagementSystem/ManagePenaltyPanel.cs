using Google.Protobuf.WellKnownTypes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManagePenaltyPanel : UserControl
    {
        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        private readonly PromptService promptService;
        private readonly IssueReturnBookService issueReturnBookService;

        private int selectedId = 0;

        public ManagePenaltyPanel()
        {
            InitializeComponent();

            this.promptService = new PromptService();
            this.issueReturnBookService = new IssueReturnBookService(connectionString);
        }
        public void RefreshBookDataGridView()
        {
            issueReturnBooksDataGridView.DataSource = this.issueReturnBookService.ListDue();
            this.ResetForm();
        }

        private void ManageBookPanel_Load(object sender, EventArgs e)
        {
            this.RefreshBookDataGridView();
        }

        private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.issueReturnBooksDataGridView.Rows[e.RowIndex];
            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            bool isPenaltyPaid = row.Cells["IsPenaltyPaid"].Value.ToString() == "No";

            if (!isPenaltyPaid)
            {
                this.payButton.Enabled = false;
                return;
            }

            this.selectedId = id;
            this.payButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }
        
        private void ResetForm()
        {
            this.selectedId = 0;
            this.payButton.Enabled = false;
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isConfirmed = this.promptService.ShowConfirmation("Mark this as paid record?");

                if (isConfirmed)
                {
                    this.issueReturnBookService.Return(this.selectedId, true);
                    this.RefreshBookDataGridView();

                    MessageBox.Show("Record updated succesfully!");
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
    }
}

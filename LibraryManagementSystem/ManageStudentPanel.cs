using Google.Protobuf.WellKnownTypes;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManageStudentPanel : UserControl
    {
        private readonly StudentService studentService;
        private readonly PromptService promptService;

        private readonly string connectionString = "Server=localhost;Database=lms_db;User ID=root;Password=;";

        private int selectedId = 0;

        public ManageStudentPanel()
        {
            InitializeComponent();

            this.studentService = new StudentService(connectionString);
            this.promptService = new PromptService();
        }

        private void ManageBookPanel_Load(object sender, EventArgs e)
        {
            this.RefreshStudentDataGridView();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = Convert.ToInt32(Math.Round(this.studentIdNumericUpDown.Value, 0));
                int yearLevel = Convert.ToInt32(Math.Round(this.yearLevelNumericUpDown.Value, 0));

                if (studentId == 0 || yearLevel == 0)
                {
                    return;
                }

                string section = this.sectionTextBox.Text;
                string firstName = this.firstNameTextBox.Text;
                string middletName = this.middleNameTextBox.Text;
                string lastName = this.lastNameTextBox.Text;
                string contactNo = this.contactNoTextBox.Text;
                string email = this.emailTextBox.Text;
                string address = this.addressTextBox.Text;

                Console.WriteLine(studentId);

                Student newStudent = new Student(studentId, yearLevel, section, firstName, middletName, lastName, contactNo, email, address);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to add this student details?");
                if (isConfirmed)
                {
                    this.studentService.Add(newStudent);
                    this.RefreshStudentDataGridView();
                    MessageBox.Show("Student added succesfully");
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
                int id = this.selectedId;
                int studentId = Convert.ToInt32(Math.Round(this.studentIdNumericUpDown.Value, 0));
                int yearLevel = Convert.ToInt32(Math.Round(this.yearLevelNumericUpDown.Value, 0));
                string section = this.sectionTextBox.Text;
                string firstName = this.firstNameTextBox.Text;
                string middletName = this.middleNameTextBox.Text;
                string lastName = this.lastNameTextBox.Text;
                string contactNo = this.contactNoTextBox.Text;
                string email = this.emailTextBox.Text;
                string address = this.addressTextBox.Text;

                Student updatedStudent = new Student(id, studentId, yearLevel, section, firstName, middletName, lastName, contactNo, email, address);

                bool isConfirmed = this.promptService.ShowConfirmation("Do you want to update this student details?");
                if (isConfirmed)
                {
                    this.studentService.Update(updatedStudent);
                    this.RefreshStudentDataGridView();
                    MessageBox.Show("Student updated succesfully");
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
            bool isConfirmed = this.promptService.ShowConfirmation("Do you want to delete this student details?");

            if (isConfirmed)
            {
                this.studentService.Delete(this.selectedId);
                this.RefreshStudentDataGridView();
                MessageBox.Show("Student deleted succesfully");
            }
            else
            {
                this.ResetForm();
            }
        }

        private void RefreshStudentDataGridView()
        {
            studentsDataGridView.DataSource = this.studentService.List();
            this.ResetForm();
        }

        private void StudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            DataGridViewRow row = this.studentsDataGridView.Rows[e.RowIndex];

            int id = Int32.Parse(row.Cells["id"].Value.ToString());
            int studentId = Int32.Parse(row.Cells["studentId"].Value.ToString());
            int yearLevel = Int32.Parse(row.Cells["yearLevel"].Value.ToString());
            string section = row.Cells["section"].Value.ToString();
            string firstName = row.Cells["firstName"].Value.ToString();
            string middleName = row.Cells["middleName"].Value.ToString();
            string lastName = row.Cells["lastName"].Value.ToString();
            string contactNo = row.Cells["contactNo"].Value.ToString();
            string email = row.Cells["email"].Value.ToString();
            string address = row.Cells["address"].Value.ToString();
            this.selectedId = id;
            this.studentIdNumericUpDown.Value = studentId;
            this.yearLevelNumericUpDown.Value = yearLevel;
            this.sectionTextBox.Text = section;
            this.firstNameTextBox.Text = firstName;
            this.middleNameTextBox.Text = middleName;
            this.lastNameTextBox.Text = lastName;
            this.contactNoTextBox.Text = contactNo;
            this.emailTextBox.Text = email;
            this.addressTextBox.Text = address;

            this.deleteButton.Enabled = true;
            this.updateButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }
        
        private void ResetForm()
        {
            this.studentIdNumericUpDown.Value = 0;
            this.yearLevelNumericUpDown.Value = 0;
            this.sectionTextBox.Text = "";
            this.firstNameTextBox.Text = "";
            this.middleNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.contactNoTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.addressTextBox.Text = "";

            this.studentIdNumericUpDown.ResetText();
            this.yearLevelNumericUpDown.ResetText();

            this.deleteButton.Enabled = false;
            this.updateButton.Enabled = false;
        }
    }
}

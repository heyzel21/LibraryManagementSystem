using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StudentDetails : Form
    {
        public StudentDetails(Student student)
        {
            InitializeComponent();
            this.PopulateData(student);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PopulateData(Student student)
        {
            Console.Write("Yearlevel" + student.yearLevel);
            this.studentIdPlaceholder.Text = student.studentId.ToString();
            this.yearLevelPlaceholder.Text = student.yearLevel.ToString();
            this.sectionPlaceholder.Text = student.section;
            this.firstNamePlaceholder.Text = student.firstName;
            this.middleNamePlaceholder.Text = student.middleName;
            this.lastNamePlaceholder.Text = student.lastName;
            this.emailPlaceholder.Text = student.email;
            this.contactNoPlaceholder.Text = student.contactNo;
            this.addressPlaceholder.Text = student.address;
        }
    }
}

using System;

namespace LibraryManagementSystem
{
    public class Student
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public int yearLevel { get; set; }
        public string section { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public Student(int id, int studentId, int yearLevel, string section, string firstName, string middleName, string lastName, string contactNo, string email, string address)
        {
            this.id = id;
            this.studentId = studentId;
            this.yearLevel = yearLevel;
            this.section = section;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.contactNo = contactNo;
            this.email = email;
            this.address = address;
        }

        public Student(int studentId, int yearLevel, string section, string firstName, string middleName, string lastName, string contactNo, string email, string address)
        {
            this.studentId = studentId;
            this.yearLevel = yearLevel;
            this.section = section;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.contactNo = contactNo;
            this.email = email;
            this.address = address;
        }

        public Student() { }
    }
}

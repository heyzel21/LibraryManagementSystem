using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public class StudentService
    {
        private string connectionString;

        public StudentService(string connString)
        {
            connectionString = connString;
        }

        public List<Student> List()
        {
            List<Student> studentList = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            int studentId = reader.GetInt32("student_id");
                            int yearLevel = reader.GetInt32("year_level");
                            string section = reader.GetString("section");
                            string firstName = reader.GetString("first_name");
                            string middleName = reader.GetString("middle_name");
                            string lastName = reader.GetString("last_name");
                            string contactNo = reader.GetString("contact_no");
                            string email = reader.GetString("email");
                            string address = reader.GetString("address");

                            Student student = new Student(id, studentId, yearLevel, section, firstName, middleName, lastName, contactNo, email, address);

                            // Add the student object to the List
                            studentList.Add(student);
                        }

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }

            return studentList;
        }

        public Student GetByStudentId(int _studentId)
        {
            Student student = new Student();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM students WHERE student_id = @StudentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StudentId", _studentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student.id = reader.GetInt32("id");
                            student.studentId = reader.GetInt32("student_id");
                            student.yearLevel = reader.GetInt32("year_level");
                            student.section = reader.GetString("section");
                            student.firstName = reader.GetString("first_name");
                            student.middleName = reader.GetString("middle_name");
                            student.lastName = reader.GetString("last_name");
                            student.contactNo = reader.GetString("contact_no");
                            student.email = reader.GetString("email");
                            student.address = reader.GetString("address");
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }

                return student;
            }
        }

        public void Add(Student newStudent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO students (student_id, year_level, section, first_name, middle_name, last_name, contact_no, email, address) VALUES (@StudentId, @YearLevel, @Section, @FirstName, @MiddleName, @LastName, @ContactNo, @Email, @Address)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentId", newStudent.studentId);
                    cmd.Parameters.AddWithValue("@YearLevel", newStudent.yearLevel);
                    cmd.Parameters.AddWithValue("@Section", newStudent.section);
                    cmd.Parameters.AddWithValue("@FirstName", newStudent.firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", newStudent.middleName);
                    cmd.Parameters.AddWithValue("@LastName", newStudent.lastName);
                    cmd.Parameters.AddWithValue("@ContactNo", newStudent.contactNo);
                    cmd.Parameters.AddWithValue("@Email", newStudent.email);
                    cmd.Parameters.AddWithValue("@Address", newStudent.address);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }

        public void Update(Student newStudent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE students SET student_id = @StudentId, year_level = @YearLevel, section = @Section, first_name = @FirstName, middle_name = @MiddleName, last_name = @LastName, contact_no = @ContactNo, email = @Email, address = @Address WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentId", newStudent.studentId);
                    cmd.Parameters.AddWithValue("@YearLevel", newStudent.yearLevel);
                    cmd.Parameters.AddWithValue("@Section", newStudent.section);
                    cmd.Parameters.AddWithValue("@FirstName", newStudent.firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", newStudent.middleName);
                    cmd.Parameters.AddWithValue("@LastName", newStudent.lastName);
                    cmd.Parameters.AddWithValue("@ContactNo", newStudent.contactNo);
                    cmd.Parameters.AddWithValue("@Email", newStudent.email);
                    cmd.Parameters.AddWithValue("@Address", newStudent.address);
                    cmd.Parameters.AddWithValue("@Id", newStudent.id);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }

        public void Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM students WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }
    }
}

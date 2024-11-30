using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public class IssueReturnBookService
    {
        private readonly string connectionString;
        private readonly StudentService studentService;

        public IssueReturnBookService(string connString)
        {
            connectionString = connString;
            studentService = new StudentService(connString);

            this.CreateIssuedBooksTable();
        }

        public List<IssueReturnBook> List()
        {
            List<IssueReturnBook> issueReturnBookList = new List<IssueReturnBook>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM issued_books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            int studentId = reader.GetInt32("student_id");
                            Student student = this.studentService.GetById(studentId);
                            int bookId = reader.GetInt32("book_id");
                            DateTime dateBorrow = reader.GetDateTime("date_borrow").Date;

                            IssueReturnBook issueReturnBook = new IssueReturnBook(id, student.studentId, bookId, dateBorrow);

                            issueReturnBookList.Add(issueReturnBook);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }

            return issueReturnBookList;
        }

        public void Add(IssueReturnBook newIssueReturnBook)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Corrected query with subquery for student ID
                    string query = "INSERT INTO issued_books (student_id, book_id, date_borrow) VALUES ((SELECT id FROM students WHERE student_id = @StudentId), @BookId, @DateBorrow);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentId", newIssueReturnBook.studentId);
                    cmd.Parameters.AddWithValue("@BookId", newIssueReturnBook.bookId);
                    cmd.Parameters.AddWithValue("@DateBorrow", newIssueReturnBook.dateBorrow);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle and log the exception
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
                    string query = "DELETE FROM issued_books WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@id", id);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle and log exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }

        private void CreateIssuedBooksTable()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to create the issued_books table with foreign key constraints
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS issued_books (
                            id INT AUTO_INCREMENT PRIMARY KEY,
                            student_id INT NOT NULL,
                            book_id INT NOT NULL,
                            date_borrow TIMESTAMP NOT NULL,
                            CONSTRAINT fk_student_id FOREIGN KEY (student_id) REFERENCES students(id) ON DELETE NO ACTION ON UPDATE NO ACTION,
                            CONSTRAINT fk_book_id FOREIGN KEY (book_id) REFERENCES books(id) ON DELETE NO ACTION ON UPDATE NO ACTION
                        );
                    ";

                    // Execute the table creation query
                    MySqlCommand cmd = new MySqlCommand(createTableQuery, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    // Handle and log the exception
                    Console.WriteLine("Database error: " + ex.Message);
                    throw;
                }
            }
        }
    }
}

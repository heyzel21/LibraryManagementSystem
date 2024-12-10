using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public class IssueReturnBookService
    {
        private readonly int penalty_amount_rule = 5;
        private readonly string connectionString;
        private readonly StudentService studentService;

        public IssueReturnBookService(string connString)
        {
            connectionString = connString;
            studentService = new StudentService(connString);

            this.CreateTable();
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
                            DateTime dateReturn = reader.GetDateTime("date_return").Date;
                            bool isReturned = reader.GetBoolean("is_returned");

                            IssueReturnBook issueReturnBook = new IssueReturnBook(id, student.studentId, bookId, dateBorrow, dateReturn, isReturned);

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

        public List<Penalty> ListDue()
        {
            List<Penalty> issueReturnBookList = new List<Penalty>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM issued_books WHERE date_return < CURRENT_DATE AND (is_returned = FALSE OR is_penalty_paid = TRUE)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            int studentId = reader.GetInt32("student_id");
                            Student student = this.studentService.GetById(studentId);
                            bool isPenaltyPaid = reader.GetBoolean("is_penalty_paid");
                            DateTime dateReturn = reader.GetDateTime("date_return").Date;
                            double penaltyAmount = 0;

                            if (!isPenaltyPaid)
                            {
                                penaltyAmount = Math.Floor((DateTime.Now - dateReturn).TotalDays) * this.penalty_amount_rule;
                            }

                            Penalty penalty = new Penalty(id, student.studentId, isPenaltyPaid, penaltyAmount);

                            issueReturnBookList.Add(penalty);
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

            //int penaltyPaid = 0;
            //int penaltyPending = 0;

            //for (int i = 0; i < issueReturnBookList.Count; i++)
            //{
            //    if (issueReturnBookList[i].IsPenaltyPaid == "Yes")
            //    {
            //        penaltyPaid++;
            //    } 
            //    else
            //    {
            //        penaltyPending++;
            //    }
            //}

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
                    string query = "INSERT INTO issued_books (student_id, book_id, date_borrow, date_return) VALUES ((SELECT id FROM students WHERE student_id = @StudentId), @BookId, @DateBorrow, @DateReturn);";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentId", newIssueReturnBook.studentId);
                    cmd.Parameters.AddWithValue("@BookId", newIssueReturnBook.bookId);
                    cmd.Parameters.AddWithValue("@DateBorrow", newIssueReturnBook.dateBorrow);
                    cmd.Parameters.AddWithValue("@DateReturn", newIssueReturnBook.dateReturn);

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

        public void Return(int id, bool isPenaltyApplied = false)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "";

                    if (isPenaltyApplied)
                    {
                        query = "UPDATE issued_books SET is_penalty_paid = TRUE, is_returned = TRUE WHERE id = @Id";
                    }
                    else
                    {
                        query = "UPDATE issued_books SET is_returned = TRUE WHERE id = @Id";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Id", id);

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

        private void CreateTable()
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
                            date_return TIMESTAMP NULL,
                            is_returned BOOLEAN NOT NULL DEFAULT FALSE,
                            is_penalty_paid BOOLEAN NOT NULL DEFAULT FALSE,
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

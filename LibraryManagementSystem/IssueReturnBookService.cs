using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class IssueReturnBookService
    {
        private readonly string connectionString;

        public IssueReturnBookService(string connString)
        {
            connectionString = connString;
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
                            int bookId = reader.GetInt32("book_id");
                            DateTime dateBorrow = reader.GetDateTime("date_borrow").Date;
                            DateTime dateReturn = reader.GetDateTime("date_return").Date;

                            IssueReturnBook issueReturnBook = new IssueReturnBook(id, studentId, bookId, dateBorrow, dateReturn);

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
                    string query = "INSERT INTO issued_books (student_id, book_id, date_borrow) VALUES (@StudentId, @BookId, @DateBorrow)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@StudentId", newIssueReturnBook.studentId);
                    cmd.Parameters.AddWithValue("@BookId", newIssueReturnBook.bookId);
                    cmd.Parameters.AddWithValue("@DateBorrow", newIssueReturnBook.dateBorrow);

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

        public void Return(IssueReturnBook issueReturnBook)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE issued_books SET return_date = @ReturnDate WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Id", issueReturnBook.id);
                    cmd.Parameters.AddWithValue("@ReturnDate", issueReturnBook.dateReturn);

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
    }
}

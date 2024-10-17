using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class BookService
    {
        private string connectionString;

        public BookService(string connString)
        {
            connectionString = connString;
        }

        public List<Book> List()
        {
            List<Book> booksList = new List<Book>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a book object to store book details
                            Book book = new Book
                            {
                                id = reader.GetInt32("id"),
                                title = reader.GetString("title"),
                                author = reader.GetString("author"),
                                publishedDate = reader.GetDateTime("published_date"),
                                quantity = reader.GetInt32("quantity"),
                            };

                            // Add the book object to the List
                            booksList.Add(book);
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

            return booksList;
        }

        public void Add(Book newBook)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO books (title, author, published_date, quantity) VALUES (@Title, @Author, @PublishedDate, @Quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Title", newBook.title);
                    cmd.Parameters.AddWithValue("@Author", newBook.author);
                    cmd.Parameters.AddWithValue("@PublishedDate", newBook.publishedDate);
                    cmd.Parameters.AddWithValue("@Quantity", newBook.quantity);

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

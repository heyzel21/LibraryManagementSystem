using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class BookService
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
                            int id = reader.GetInt32("id");
                            string title = reader.GetString("title");
                            string author = reader.GetString("author");
                            DateTime publishedDate = reader.GetDateTime("published_date").Date;
                            int quantity = reader.GetInt32("quantity");

                            Book book = new Book(id, title, author, publishedDate, quantity);

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

        public void Update(Book newBook)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE books SET title = @Title, author = @Author, published_date = @PublishedDate, quantity = @Quantity WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the query to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Id", newBook.id);
                    cmd.Parameters.AddWithValue("@Title", newBook.title);
                    cmd.Parameters.AddWithValue("@Author", newBook.author);
                    cmd.Parameters.AddWithValue("@PublishedDate", newBook.publishedDate);
                    cmd.Parameters.AddWithValue("@Quantity", newBook.quantity);

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
                    string query = "DELETE FROM books WHERE id=@id";
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

        public Book GetById(int _id)
        {
            Book book = new Book();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM books WHERE id = @Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id", _id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            book.id = reader.GetInt32("id");
                            book.title = reader.GetString("title");
                            book.author = reader.GetString("author");
                            book.quantity = reader.GetInt32("quantity");
                            book.publishedDate = reader.GetDateTime("published_date").Date;
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

                return book;
            }
        }
    }
}

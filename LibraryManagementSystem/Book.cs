using System;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public DateTime publishedDate { get; set; }
        public int quantity { get; set; }

        public Book(int id, string title, string author, DateTime publishedDate, int quantity)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publishedDate = publishedDate;
            this.quantity = quantity;
        }

        public Book( string title, string author, DateTime publishedDate, int quantity)
        {
            this.title = title;
            this.author = author;
            this.publishedDate = publishedDate;
            this.quantity = quantity;
        }
    }
}

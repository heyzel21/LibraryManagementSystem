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
    }
}

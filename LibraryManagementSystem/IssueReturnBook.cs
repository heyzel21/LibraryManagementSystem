using System;

namespace LibraryManagementSystem
{
    public class IssueReturnBook
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public int bookId { get; set; }
        public DateTime dateBorrow {  get; set; }
        public DateTime dateReturn { get; set; }

        public IssueReturnBook(int id, int studentId, int bookId, DateTime dateBorrow, DateTime dateReturn)
        {
            this.id = id;
            this.studentId = studentId;
            this.bookId = bookId;
            this.dateBorrow = dateBorrow;
            this.dateReturn = dateReturn;
        }

        public IssueReturnBook(int studentId, int bookId, DateTime dateBorrow)
        {
            this.studentId = studentId;
            this.bookId = bookId;
            this.dateBorrow = dateBorrow;
        }
    }
}

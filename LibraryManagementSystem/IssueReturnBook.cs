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
        public string IsReturned { get; set; } = "No";

        public IssueReturnBook(int id, int studentId, int bookId, DateTime dateBorrow, DateTime dateReturn, bool isReturned)
        {
            this.id = id;
            this.studentId = studentId;
            this.bookId = bookId;
            this.dateBorrow = dateBorrow;
            this.dateReturn = dateReturn;

            if (isReturned )
            {
                this.IsReturned = "Yes";
            }
        }

        public IssueReturnBook(int id, int studentId, int bookId, DateTime dateBorrow)
        {
            this.id = id;
            this.studentId = studentId;
            this.bookId = bookId;
            this.dateBorrow = dateBorrow;
        }

        public IssueReturnBook(int studentId, int bookId, DateTime dateBorrow, DateTime dateReturn)
        {
            this.studentId = studentId;
            this.bookId = bookId;
            this.dateBorrow = dateBorrow;
            this.dateReturn = dateReturn;
        }
    }
}

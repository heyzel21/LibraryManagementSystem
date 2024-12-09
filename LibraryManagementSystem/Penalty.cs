using System;

namespace LibraryManagementSystem
{
    public class Penalty
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string IsPenaltyPaid { get; set; } = "No";

        public Penalty(int Id, int StudentId, bool IsPenaltyPaid)
        {
            this.Id = Id;
            this.StudentId = StudentId;

            if (IsPenaltyPaid)
            {
                this.IsPenaltyPaid = "Yes";
            }
        }
    }
}

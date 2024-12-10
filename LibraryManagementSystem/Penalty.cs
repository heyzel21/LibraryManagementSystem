using System;

namespace LibraryManagementSystem
{
    public class Penalty
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string IsPenaltyPaid { get; set; } = "No";
        public double PenaltyAmount { get; set; } = 0;


        public Penalty(int Id, int StudentId, bool IsPenaltyPaid, double PenaltyAmount)
        {
            this.Id = Id;
            this.StudentId = StudentId;
            this.PenaltyAmount = PenaltyAmount;

            if (IsPenaltyPaid)
            {
                this.IsPenaltyPaid = "Yes";
            }
        }
    }
}

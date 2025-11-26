using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class TuitionFee
    {
        [Key]
        public int TuitionId { get; set; }

        public int StudentId { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }
        public string TotalAmount { get; set; }
        public string PaidAmount { get; set; }
        public string DebtAmount { get; set; }

        // Navigation
        public ICollection<TuitionPayment> Payments { get; set; }
    }
}

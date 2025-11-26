using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class TuitionPayment
    {
        [Key]
        public int PaymentId { get; set; }

        public int TuitionId { get; set; }
        public string Amount { get; set; }
        public string DatePaid { get; set; }
        public string Note { get; set; }

        public TuitionFee Tuition { get; set; }
    }
}

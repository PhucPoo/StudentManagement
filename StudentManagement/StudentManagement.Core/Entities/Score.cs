using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }

        public int EnrollmentId { get; set; }

        public float Midterm { get; set; }
        public float Final { get; set; }
        public float Other { get; set; }
        public float Total { get; set; }
        public bool IsRegradeRequested { get; set; }

        // Navigation
        public Enrollment Enrollment { get; set; }
        public ICollection<RegradeRequest> RegradeRequests { get; set; }
    }
}

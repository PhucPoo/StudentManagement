using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public int CourseClassId { get; set; }
        public string Status { get; set; }

        // Navigation
       
        public CourseClass CourseClass { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}

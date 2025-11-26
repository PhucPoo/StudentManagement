using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class CourseClass
    {
        [Key]
        public int CourseClassId { get; set; }

        public int SubjectId { get; set; }
        public int LecturerId { get; set; }
        public string Semester { get; set; }
        public DateTime Year { get; set; }
        public int ScheduleId { get; set; }

        // Navigation
        public Subject Subject { get; set; }
        public Schedule Schedule { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

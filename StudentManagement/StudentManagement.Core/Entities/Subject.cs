using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }
        public int Credits { get; set; }

        public ICollection<CourseClass> CourseClasses { get; set; }
    }
}

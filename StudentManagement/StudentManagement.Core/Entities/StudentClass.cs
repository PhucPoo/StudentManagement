using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class StudentClass
    {
        [Key]
        public int ClassId { get; set; }

        public string ClassName { get; set; }
        public int MajorId { get; set; }

        // Navigation
        public Major Major { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

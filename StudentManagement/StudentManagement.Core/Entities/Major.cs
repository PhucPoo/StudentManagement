using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Major
    {
        [Key]
        public int MajorId { get; set; }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public Department Department { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

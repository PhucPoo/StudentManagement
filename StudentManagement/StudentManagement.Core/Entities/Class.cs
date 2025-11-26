using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        // 1 class – nhiều studentclass
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}

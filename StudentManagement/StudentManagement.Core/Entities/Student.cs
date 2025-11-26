using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public int UserId { get; set; }
        public int ClassId { get; set; }
        public int MajorId { get; set; }

        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Status { get; set; }

        // Navigation
        public User User { get; set; }
        public Major Major { get; set; }
        public StudentClass StudentClass { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
       
    }
}

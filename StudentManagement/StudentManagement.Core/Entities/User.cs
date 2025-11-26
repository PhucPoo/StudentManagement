using System.ComponentModel.DataAnnotations;

namespace StudentManagement.StudentManagement.Core.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }      // admin / student
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation
        public Student Student { get; set; }
    }
}

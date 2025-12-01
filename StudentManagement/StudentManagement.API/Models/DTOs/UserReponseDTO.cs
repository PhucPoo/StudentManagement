using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class UserReponseDTO
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}

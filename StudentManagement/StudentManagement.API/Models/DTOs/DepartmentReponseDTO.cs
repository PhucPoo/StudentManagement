using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class DepartmentReponseDTO
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public int MajorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}


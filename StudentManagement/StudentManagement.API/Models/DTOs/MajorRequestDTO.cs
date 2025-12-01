namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class MajorRequestDTO
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

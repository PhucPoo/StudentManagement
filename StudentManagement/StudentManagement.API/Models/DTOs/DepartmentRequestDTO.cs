namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class DepartmentRequestDTO
    {
        public string Name { get; set; }

        public int MajorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class MajorReponseDTO
    {
        public int MajorId { get; set; }

        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

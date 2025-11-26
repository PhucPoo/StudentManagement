namespace StudentManagement.StudentManagement.API.Models.DTOs
{
    public class StudentReponseDTO
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Status { get; set; }
        public int ClassId { get; set; }
        public int MajorId { get; set; }
        public int UserId { get; set; }
    }
}

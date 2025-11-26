using AutoMapper;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class StudentProfile : Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentReponseDTO>().ReverseMap();
        CreateMap<StudentRequestDTO, Student>();
    }
}

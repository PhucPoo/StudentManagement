using AutoMapper;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.API.Mapping
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentReponseDTO>().ReverseMap();
            CreateMap<DepartmentRequestDTO, Department>();
        }
    }
}

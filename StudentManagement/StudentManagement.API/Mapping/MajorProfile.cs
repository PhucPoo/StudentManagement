using AutoMapper;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.API.Mapping
{
    public class MajorProfile : Profile
    {
        public MajorProfile()
        {
            CreateMap<Major, MajorReponseDTO>().ReverseMap();
            CreateMap<MajorRequestDTO, Major>();
        }
    }
}

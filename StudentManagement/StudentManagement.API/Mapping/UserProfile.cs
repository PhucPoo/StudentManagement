using AutoMapper;
using StudentManagement.StudentManagement.API.Models.DTOs;
using StudentManagement.StudentManagement.Core.Entities;

namespace StudentManagement.StudentManagement.API.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReponseDTO>().ReverseMap();
            CreateMap<UserRequestDTO, User>();
        }
    }

}

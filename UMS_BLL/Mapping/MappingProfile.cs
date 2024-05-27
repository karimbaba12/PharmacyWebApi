using AutoMapper;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Majors;
using UMS_BLL.DTO.Users;
using UMS_DAL.Models;

namespace UMS_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Faculty, FacultyDto>().ReverseMap();
            CreateMap<Major, MajorDto>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}

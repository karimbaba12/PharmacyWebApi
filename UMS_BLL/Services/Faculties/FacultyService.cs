using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Faculties;

namespace UMS_BLL.Services.Faculties
{
    public class FacultyService: GenericService<Faculty, FacultyDto>, IFacultyService
    {
        public readonly IFacultyRepository _facultyRepository;
        public readonly IMapper _mapper;

        public FacultyService(IFacultyRepository facultyRepository, IMapper mapper) : base(facultyRepository, mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;
        }

        public ApiResponse<FacultyDto> GetFacultyByName(string name)
        {
            var response = new ApiResponse<FacultyDto>();
            var result = _facultyRepository.GetFacultyByName(name); 
            response.Data= _mapper.Map<FacultyDto>(result);
            return response;
        }
    }
}

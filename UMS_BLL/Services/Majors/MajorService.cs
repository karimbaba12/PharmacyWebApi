using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Majors;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;
using UMS_DAL.Repositories.Majors;

namespace UMS_BLL.Services.Majors
{

    using Entity = Major;
    using dto = MajorDto;
    public class MajorService : GenericService<Entity, dto>, IMajorService
    {
        public readonly IMajorRepository _majorRepository;
        public readonly IMapper _mapper;

        public MajorService(IMajorRepository majorRepository, IMapper mapper) : base(majorRepository, mapper) 
        {
            _majorRepository = majorRepository;
            _mapper = mapper;
        }


        public ApiResponse<IEnumerable<dto>> GetMajorByFacultyId(int facultyId)
        {
            var response = new ApiResponse<IEnumerable<dto>>();
            var result =  _majorRepository.GetMajorByFacultyId(facultyId);
            response.Data =  _mapper.Map<IEnumerable<dto>>(result);
            return response;
        }




    }
}

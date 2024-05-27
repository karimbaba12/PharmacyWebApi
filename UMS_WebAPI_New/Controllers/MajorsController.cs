using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Majors;
using UMS_BLL.Services.Majors;
using UMS_BLL.Wrapping;
using UMS_WebAPI_New.Controllers.GenericsController;

namespace UMS_WebAPI_New.Controllers
{
    public class MajorsController : GenericController<MajorDto>
    {
        private readonly IMajorService _service;

        public MajorsController(IMajorService service) : base(service) 
        {
            _service = service;
        
        }
        

        [HttpGet("GetMajorByFacultyId")]
        public ApiResponse<IEnumerable<MajorDto>> GetMajorByFacultyId(int id) 
        {
        return _service.GetMajorByFacultyId(id);
        }
    }
}

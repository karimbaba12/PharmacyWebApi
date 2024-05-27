using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;
using UMS_WebAPI_New.Controllers.GenericsController;

namespace UMS_WebAPI_New.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FacultiesController : GenericController<FacultyDto>
    {

        private readonly IFacultyService _facultyService;
        

        public FacultiesController(IFacultyService service) : base (service)
        {

            _facultyService = service;
           
        }

        [HttpGet("GetFcultyByName")]
        public ApiResponse<FacultyDto> GetFacultyByName(string name)
        {
            return _facultyService.GetFacultyByName(name);
        }
        

    }
}

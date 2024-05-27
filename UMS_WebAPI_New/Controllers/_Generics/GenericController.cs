using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;

namespace UMS_WebAPI_New.Controllers.GenericsController
{
    [Route("api/[Controller]")]
    [ApiController] 
    public class GenericController<Dto> : Controller where Dto : class
    
        {

        public readonly IGenericService<Dto> _service;
           public GenericController(IGenericService<Dto> service)
            {
            
            _service = service;
            }



            [HttpGet("GetAll")]
           
        public ApiResponse<IEnumerable<Dto>> GetAll()
        {
            return _service.GetAll();
        }
        /*public IEnumerable<Dto> GetAll()
           {
               return _service.GetAll();
           }*/


        [HttpGet("GetById")]

        public ApiResponse<Dto> GetFacultyById(int id)
        {
            return _service.GetById(id);
        }

        /*public Dto GetFacultyById(int id)
        {
            return _service.GetById(id);
        }
*/

        [HttpPost("Add")]

        public ApiResponse<Dto> Add(Dto dto)
        {
            return _service.Add(dto);
        }
        /*public Dto Add(Dto dto)
        {
            return _service.Add(dto);
        }*/

        [HttpPut("Update")]

        public ApiResponse<Dto> Update(Dto dto)
        {
            return _service.Update(dto);
        }
        /* public Dto Update(Dto dto)
         {
             return _service.Update(dto);
         }*/


        [HttpDelete("DeleteById")]

        public ApiResponse<bool> DeleteById(int id)
        {
            return _service.Delete(id);
        }
        /* public bool DeleteById(int id)
         {
             return _service.Delete(id);
         }*/


        [HttpDelete("Delete")]

        public ApiResponse<bool> Delete(Dto dto)
        {
            return _service.Delete(dto);
        }
        /* public bool Delete(Dto dto)
         {
             return _service.Delete(dto);
         }*/






    }
}

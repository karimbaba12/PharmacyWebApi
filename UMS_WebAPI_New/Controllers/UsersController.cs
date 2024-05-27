using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Services.Majors;
using UMS_BLL.Services.Users;
using UMS_BLL.Wrapping;
using UMS_WebAPI_New.Controllers.GenericsController;

namespace UMS_WebAPI_New.Controllers
{
    public class UsersController : GenericController<UserDTO>
    {

        private readonly IUserService _service;

        public UsersController(IUserService service) : base(service)
        {
            _service = service;
        }

        [HttpPost("Login")]
        public ApiResponse<bool> Login (LoginRequestDTO loginRequest)
        {
            var response = new ApiResponse<bool>();

            //_service.login(loginRequest.UserName,loginRequest.Password);
            var result =  _service.login(loginRequest);
            return response;
        }

        
    }
}

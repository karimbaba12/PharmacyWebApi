using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Users;
using UMS_BLL.Wrapping;
using UMS_DAL.Repositories.Users;

namespace UMS_WebAPI_New.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController (IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Auth")]
        public ApiResponse<bool> Login(LoginRequestDTO loginRequest)
        {
            var result = _authService.login(loginRequest);
            return result;
        }


    }
}

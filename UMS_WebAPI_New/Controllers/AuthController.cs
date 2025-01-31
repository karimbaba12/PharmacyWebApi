using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.Users;
using UMS_BLL.Wrapping;
using Microsoft.Extensions.Configuration;

namespace UMS_WebAPI_New.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IConfiguration _configuration;

        public AuthController(IUserService service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public ApiResponse<string> Login(LoginRequestDTO loginRequest)
        {
            var response = new ApiResponse<string>();

            var user = _service.login(loginRequest);

            if (user != null)
            {
                var token = GenerateJwtToken(user.UserName);
                response.Data = token;
                response.Success = true;
                response.Message = "Login successful";
            }
            else
            {
                response.Success = false;
                response.Message = "Invalid username or password";
                response.Data = null; 
            }

            return response;
        }
        [HttpPost("RefreshToken")]
        public ApiResponse<string> RefreshToken(string currentToken)
        {
            var response = new ApiResponse<string>();
            var handler = new JwtSecurityTokenHandler();

            try
            {
                var token = handler.ReadJwtToken(currentToken);
                var userName = token.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;

                if (!string.IsNullOrEmpty(userName))
                {
                    var newToken = GenerateJwtToken(userName);
                    response.Data = newToken;
                    response.Success = true;
                    response.Message = "Token refreshed successfully";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Invalid token";
                }
            }
            catch
            {
                response.Success = false;
                response.Message = "Token verification failed";
            }

            return response;
        }


        private string GenerateJwtToken(string userName)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
        new Claim(JwtRegisteredClaimNames.Sub, userName),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64) };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
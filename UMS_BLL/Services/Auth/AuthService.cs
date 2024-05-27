using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Users;
using UMS_BLL.Wrapping;
using UMS_DAL.Repositories.Users;

namespace UMS_BLL.Services.Auth
{
    public class AuthService : IAuthService
    {
          public readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public ApiResponse<bool> login(LoginRequestDTO loginRequestDTO)
        {
            //get user from data base based on username
            var username = loginRequestDTO.UserName;
            var password = loginRequestDTO.Password;
            var user = _userRepository.GetUserByUserName(username);

            if (user == null)
            {
                throw new Exception("username not found");

            }
            if (user.Password != password)
            {
                throw new Exception("wrong password");
            }

            return new ApiResponse<bool>(true);
           
        }
    }
}

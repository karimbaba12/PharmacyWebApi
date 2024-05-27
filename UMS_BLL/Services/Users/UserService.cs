using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Majors;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Services.Majors;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
using UMS_DAL.Repositories.Majors;
using UMS_DAL.Repositories.Users;

namespace UMS_BLL.Services.Users
{
    using Entity = User;
    using dto = UserDTO;
    public class UserService : GenericService<Entity, dto>, IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        //to stop the Delete
        public override ApiResponse <bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override ApiResponse<bool> Delete(dto dt)
        {
            throw new NotImplementedException();
        }

      

        public bool login(LoginRequestDTO loginRequestDTO)
        {
            //get user from data base based on username
            var username = loginRequestDTO.UserName;
            var user = _userRepository.GetUserByUserName(username);
            if (user != null)
            {
                return username == loginRequestDTO.UserName;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
    }

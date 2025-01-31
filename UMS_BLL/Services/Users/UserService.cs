using AutoMapper;
using System;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;
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

        // Override Delete methods to prevent deletion
        public override ApiResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override ApiResponse<bool> Delete(dto dt)
        {
            throw new NotImplementedException();
        }

        // Implement the login method (lowercase to match the interface)
        public dto login(LoginRequestDTO loginRequestDTO)
        {
            // Get user from the database based on username
            var user = _userRepository.GetUserByUserName(loginRequestDTO.UserName);

            if (user != null)
            {
                // Validate the password (plain text comparison - not recommended for production)
                if (user.Password == loginRequestDTO.Password)
                {
                    // Map the User entity to UserDTO
                    return _mapper.Map<dto>(user);
                }
            }

            // Return null if login fails
            return null;
        }
    }
}
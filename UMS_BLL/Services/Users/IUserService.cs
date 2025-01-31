using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Majors;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;

namespace UMS_BLL.Services.Users
{
   
using dto = UserDTO;
    public interface IUserService : IGenericService<dto>
    {
        dto login(LoginRequestDTO loginRequestDTO);
    }
}


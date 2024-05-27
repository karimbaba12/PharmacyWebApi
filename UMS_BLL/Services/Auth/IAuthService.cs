using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;

namespace UMS_BLL.Services.Auth
{
    using dto = UserDTO;
    public interface IAuthService 

        
    {
        ApiResponse<bool> login( LoginRequestDTO loginRequestDTO);

    }
}

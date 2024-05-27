using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.DTO.Users
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}

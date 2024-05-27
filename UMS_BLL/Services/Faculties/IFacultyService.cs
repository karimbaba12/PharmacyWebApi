using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculties;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Models;

namespace UMS_BLL.Services.Faculties
{
    public interface IFacultyService : IGenericService<FacultyDto>
    {
        ApiResponse<FacultyDto> GetFacultyByName(string name);
    }
}

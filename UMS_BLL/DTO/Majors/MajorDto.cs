using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.DTO.Majors
{
    public class MajorDto
    {
        public int MajorId { get; set; }

        public int FacultyId { get; set; }

        public string MajorName { get; set; } = null!;

    }
}

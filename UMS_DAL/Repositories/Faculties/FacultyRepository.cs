using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;

namespace UMS_DAL.Repositories.Faculties
{
    public class FacultyRepository : GenericRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(UmsContext umsContext) : base(umsContext)
        {
        }

        public Faculty GetFacultyByName(string name)
        {
            var result = _dbSet.Where(x => x.FacultyName == name).FirstOrDefault();
            return result;
        }
    }
}

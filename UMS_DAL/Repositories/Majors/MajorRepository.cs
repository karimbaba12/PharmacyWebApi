using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;

namespace UMS_DAL.Repositories.Majors
{
    using Entity = Major;
    public class MajorRepository : GenericRepository<Entity>, IMajorRepository
    {
        public MajorRepository(UmsContext umsContext) : base(umsContext)
        {
        }

        public IEnumerable<Major> GetMajorByFacultyId(int facultyId)
        {
           return _dbSet.Where(x=>x.FacultyId==facultyId).ToList();
        }
    }
}

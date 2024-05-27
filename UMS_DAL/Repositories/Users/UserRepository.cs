using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Faculties;

namespace UMS_DAL.Repositories.Users
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(UmsContext umsContext) : base(umsContext)
        {
        }

        public User GetUserByUserName(string username)
        {
            var result = _dbSet.Where(x => x.UserName == username).FirstOrDefault();
            return result;
        }
    }
}

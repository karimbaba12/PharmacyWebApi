using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_DAL.Repositories._GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(int id);
        T Add(T faculty);
        T Update(T faculty);
        bool Delete(int id);
        bool Delete(T faculty);
    }
}

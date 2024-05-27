using Microsoft.EntityFrameworkCore;
using UMS_DAL.Models;

namespace UMS_DAL.Repositories._GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly DbSet<T> _dbSet;
        public readonly UmsContext _umsContext;

        public GenericRepository(UmsContext umsContext)
        {
            _umsContext = umsContext;
            _dbSet = _umsContext.Set<T>();
        }
        #region Add
        public T Add(T entity)
        {
            _dbSet.Add(entity);
            try
            {
                _umsContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return entity;
        }


        #endregion

        #region Get
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        #endregion


        #region Update
        public T Update(T entity)
        {
            _dbSet.Update(entity);
            try
            {
                _umsContext.SaveChanges();
            }
            catch
            {

            }
            return entity;
        }
        #endregion

        #region Delete
        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                _umsContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                return Delete(entity);
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}

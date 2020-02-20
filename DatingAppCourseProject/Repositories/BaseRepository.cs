using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAppCourseProject.Data;
using DatingAppCourseProject.Entities.Interfaces;
using DatingAppCourseProject.Repositories.Interfaces;

namespace DatingAppCourseProject.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DatingAppCourseProjectContext _dbContext;

        public BaseRepository(DatingAppCourseProjectContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save(T entity)
        {
            if (entity == null)
            {
                _dbContext.Add(entity);
            }
            _dbContext.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public async Task<T> FindById(int id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public IEnumerable<T> FindAll()
        {
            return _dbContext.Set<T>();
        }
    }
}

using DatingAppCourseProject.Entities.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DatingAppCourseProject.Repositories.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Save(T entity);
        void Delete(T entity);
        //void Delete(long Id);
        Task<T> FindById(int Id);
        IEnumerable<T> FindAll();
    }
}

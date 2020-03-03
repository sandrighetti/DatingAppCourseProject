using System.Threading.Tasks;
using System.Collections.Generic;
using DatingAppCourseProject.Entities;

namespace DatingAppCourseProject.Repositories.Interfaces
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}

using DatingAppCourseProject.Data;
using DatingAppCourseProject.Entities;

namespace DatingAppCourseProject.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(DatingAppCourseProjectContext dbContext) : base(dbContext)
        {
        }
    }
}

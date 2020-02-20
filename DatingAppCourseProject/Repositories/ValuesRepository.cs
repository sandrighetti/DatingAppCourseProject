using DatingAppCourseProject.Data;
using DatingAppCourseProject.Entities;

namespace DatingAppCourseProject.Repositories
{
    public class ValuesRepository : BaseRepository<Value>
    {

        public ValuesRepository(DatingAppCourseProjectContext dbContext) : base(dbContext)
        {
        }
    }
}

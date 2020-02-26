using DatingAppCourseProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppCourseProject.Data
{
    public class DatingAppCourseProjectContext : DbContext
    {
        public DatingAppCourseProjectContext(DbContextOptions<DatingAppCourseProjectContext> options) : base(options)
        {
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using DatingAppCourseProject.Data;
using DatingAppCourseProject.Entities;
using DatingAppCourseProject.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatingAppCourseProject.Repositories
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DatingAppCourseProjectContext _dbcontext;

        public DatingRepository(DatingAppCourseProjectContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add<T>(T entity) where T : class
        {
            _dbcontext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbcontext.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _dbcontext.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _dbcontext.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _dbcontext.SaveChangesAsync() > 0;
        }
    }
}

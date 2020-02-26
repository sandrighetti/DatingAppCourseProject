using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using DatingAppCourseProject.Entities;

namespace DatingAppCourseProject.Data.DataSeeding
{
    public class Seed
    {
        public static void SeedUsers(DatingAppCourseProjectContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/DataSeeding/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);
                foreach (var user in users)
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash("password", out passwordHash, out passwordSalt);

                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.Username = user.Username.ToLower();
                    dbContext.Users.Add(user);
                }

                dbContext.SaveChanges();
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

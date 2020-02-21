using System.ComponentModel.DataAnnotations;
using DatingAppCourseProject.Entities.Interfaces;

namespace DatingAppCourseProject.Entities
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

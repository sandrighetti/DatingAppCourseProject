using System.ComponentModel.DataAnnotations;
using DatingAppCourseProject.Entities.Interfaces;

namespace DatingAppCourseProject.Entities
{
    public class Value : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

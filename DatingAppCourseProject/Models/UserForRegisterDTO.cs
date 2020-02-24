﻿using System.ComponentModel.DataAnnotations;

namespace DatingAppCourseProject.Models
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 10 characters.")]
        public string Password { get; set; }
    }
}

using System.Threading.Tasks;
using DatingAppCourseProject.Models;
using DatingAppCourseProject.Entities;
using DatingAppCourseProject.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DatingAppCourseProject.Repositories;

namespace DatingAppCourseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDTO userForRegisterDTO)
        {
            userForRegisterDTO.Username = userForRegisterDTO.Username.ToLower();

            if (await _authRepository.UserExists(userForRegisterDTO.Username))
            {
                return BadRequest("Username already exists.");
            }

            var userToCreate = new User { Username = userForRegisterDTO.Username };

            await _authRepository.Register(userToCreate, userForRegisterDTO.Password);

            return StatusCode(201);
        }
    }
}

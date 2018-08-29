using System.Threading.Tasks;
using JobApp.API.Data;
using JobApp.API.DTO;
using JobApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobApp.API.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }
        
        [HttpPost(template: "register")]

        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto) 
        {
            //validate request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if(await _repo.UserExists(userForRegisterDto.Username))
            {
                return BadRequest("Username already exists");
            }
            var userToCreate = new User
            {
                Username = userForRegisterDto.Username
            };

            var createdUser = await _repo.RegisterAsync(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using NewProject.Application.Abstractions;
using NewProject.Domain.Entities.Models;

namespace NewProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var result = await _userRepository.GetAll();

            return Ok(result);
        }
    }
}

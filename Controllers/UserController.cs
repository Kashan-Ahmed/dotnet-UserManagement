using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Repositories;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository = new();

        [HttpGet]
        public IActionResult GetAllUsers() => Ok(_userRepository.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userRepository.GetById(id);
            return user != null ? Ok(user) : NotFound();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.Email))
                return BadRequest("First name and email are required.");

            user.Id = _userRepository.GetAll().Count + 1; // Simple auto-increment ID
            _userRepository.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            var existingUser = _userRepository.GetById(id);
            if (existingUser == null)
                return NotFound();

            user.Id = id; 
            _userRepository.Update(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var existingUser = _userRepository.GetById(id);
            if (existingUser == null)
                return NotFound();

            _userRepository.Delete(id);
            return NoContent();
        }
    }
}

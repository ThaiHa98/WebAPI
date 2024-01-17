using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controller
{
	[ApiController]
	[Route("api/user")]
	public class UsersControlle : ControllerBase
	{
		private readonly UserService _userService;

		public UsersControlle(UserService userService)
		{
			_userService = userService;
		}
		[HttpGet]
		[HttpPost("/Register")]
		public User Register(User user)
		{
			return _userService.Register(user);
		}

        [HttpPost("/login")]
        public IActionResult Login(LoginDTo loginDTo)
        {
            if (_userService != null)
            {
                bool isAuthenticated = _userService.Login(loginDTo);

                if (isAuthenticated)
                {
                    return Ok(new { Message = "Login successful" });
                }
                else
                {
                    return Unauthorized(new { Message = "Invalid email or password" });
                }
            }
            else
            {
                return StatusCode(500, new { Message = "Internal server error" });
            }
        }
    }
}

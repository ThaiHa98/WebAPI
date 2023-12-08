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
		public IActionResult login(LoginDTo loginDTo)
		{
			return Ok(_userService.login(loginDTo));
		}
	}
}

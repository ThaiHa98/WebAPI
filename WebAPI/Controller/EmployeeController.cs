using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controller
{
	[ApiController]
	[Route("/api/Employee")]
	public class EmployeeController : ControllerBase
	{
		public readonly EmployeeService EmployeeService;

		public EmployeeController(EmployeeService employeeService)
		{
			EmployeeService = employeeService;
		}
		[HttpPost("/carate")]
		public IActionResult createStaff(Employee employee)
		{
			return Ok(EmployeeService.Save(employee));
		} 
	}
}

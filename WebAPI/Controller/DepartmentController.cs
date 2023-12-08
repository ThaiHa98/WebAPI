using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Service;

namespace WebAPI.Controller
{
	[ApiController]
	[Route("/api/Department")]
	public class DepartmentController : ControllerBase
	{
		public readonly DepatmentService _DepatmentService;

		public DepartmentController(DepatmentService depatmentService)
		{
			_DepatmentService = depatmentService;
		}
		[HttpDelete("/delete/{id}")]

		public void deleteRoonm([FromQuery] int id)
		{
			_DepatmentService.deleteDepatment(id);
		}
		

		[HttpPost("/Depatment")]
		public IActionResult createDepatment([FromBody] Department department)
		{
			return Ok(_DepatmentService.Save(department));
		}

		[HttpPost("/updateDepatment")]
		public IActionResult UpdateDepatment([FromBody] Department department)
		{
			return Ok(_DepatmentService.UpdateDepartment(department));
		}

		[HttpGet("/getbyId/{id}")]
		public IActionResult getbyId([FromQuery] int id)
		{
			return Ok(_DepatmentService.GetDepartmentById(id));
		}
	}
}

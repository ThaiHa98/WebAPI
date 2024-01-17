using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
	public class Employee
	{
		[Key]
		public int EmployeeID { set; get; }
		public int DepartmentId { set; get; }
		public String EmployeeName { set; get; }
		public String department { set; get; }
		public String Employeerank { set; get; }
	}
}

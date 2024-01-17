using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
	public class Department
	{
		[Key]
		public int Id { set; get; }
		public string Name { set; get; }
		public string Addrees { set; get; }
		public string Number { set; get; }
		public String Role { set; get; }
	}
}

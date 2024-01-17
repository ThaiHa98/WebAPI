using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
	public class User
	{
		[Key]
		public int UserId { set; get; }
		public string username { set; get; }
		public string password { set; get; }
		public string Email { get; set; }
	}
}

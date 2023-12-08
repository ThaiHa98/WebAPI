using Microsoft.EntityFrameworkCore;
using WebAPI.DataSql;
using WebAPI.DTO;
using WebAPI.Models;

namespace WebAPI.Service
{
	public class UserService
	{
		private readonly WebDbContext _db;
		public UserService(WebDbContext db)
		{
				_db = db;
		}
		public User Register(User user)
		{
			_db.Users.Add(user);
			_db.SaveChanges();
			return user;
		}
		public bool login(LoginDTo loginDto)
		{
			var email1 = _db.Users.FirstOrDefault(u => u.Email == loginDto.email);
			if (email1 != null)
			{
				string passwordHash = Endingcode.Endingcode.ComputeSha256hash(loginDto.password);
				if (email1.password == passwordHash)
				{
					return true;
				}
			}

			return false;
		}
	}
}

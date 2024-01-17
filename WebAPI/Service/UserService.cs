using Microsoft.EntityFrameworkCore;
using System.Text;
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
        public bool Login(LoginDTo loginDto)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == loginDto.email);

            if (user != null)
            {
                string hashedPassword = HashPassword(loginDto.password);

                if (user.password == hashedPassword)
                {
                    return true;
                }
            }

            return false;
        }

        private string HashPassword(string password)
        {

            return SimpleHashFunction(password);
        }

        private string SimpleHashFunction(string input)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebAPI.Models;

namespace WebAPI.DataSql
{
	public class WebDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Department> Departments { set; get; }
		public DbSet<Employee> Employees { set; get; }



		public WebDbContext(DbContextOptions<WebDbContext> options)
			: base(options)
		{

		}
	}
}

using WebAPI.DataSql;
using WebAPI.Models;

namespace WebAPI.Service
{
	public class EmployeeService
	{
		private readonly WebDbContext _db;
		public EmployeeService(WebDbContext db)
		{
			_db = db;
		}
		public Employee Save(Employee employee)
		{
			_db.Employees.Add(employee);
			_db.SaveChanges();
			return employee;
		}
	}
}

using Microsoft.EntityFrameworkCore;
using WebAPI.DataSql;
using WebAPI.Models;

namespace WebAPI.Service
{
	public class DepatmentService
	{
		private readonly WebDbContext _db;
		public DepatmentService(WebDbContext db)
		{
			_db = db;
		}
		public Department Save(Department department)
		{
			_db.Departments.Add(department);
			_db.SaveChanges();
			return department;
		}
		public void deleteDepatment(int Id)
		{
			var depatment = _db.Departments.FirstOrDefault(u => u.Id == Id);
			if (depatment != null)
			{
				_db.Departments.Remove(depatment);
				_db.SaveChanges();
			}
		}
		public List<Department> GetAllProduct()
		{
			return _db.Departments.ToList();
		}
		public Department UpdateDepartment(Department updatedDepartment)
		{
			var existingDepartment = _db.Departments.FirstOrDefault(u => u.Id == updatedDepartment.Id);
			if (existingDepartment != null)
			{
				existingDepartment.Name = updatedDepartment.Name;
				existingDepartment.Addrees = updatedDepartment.Addrees;
				existingDepartment.Number = updatedDepartment.Number;

				_db.SaveChanges();
			}

			return existingDepartment;
		}
		public Department GetDepartmentById(int Id)
		{
			// Lấy thông tin của phòng ban theo ID
			return _db.Departments.FirstOrDefault(u => u.Id == Id);
		}
	}
}

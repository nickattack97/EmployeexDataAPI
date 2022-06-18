using Microsoft.EntityFrameworkCore;

namespace EmployeexDataAPI.Data
{
	public class DataContext : DbContext
	{
		//dotnet ef migrations add CreateInitial
		//dotnet ef database update

		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Employee> Employees { get; set; }
	}
}


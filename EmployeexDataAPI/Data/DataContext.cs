using Microsoft.EntityFrameworkCore;

namespace EmployeexDataAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Employee> tblStaff { get; set; }
	}
}


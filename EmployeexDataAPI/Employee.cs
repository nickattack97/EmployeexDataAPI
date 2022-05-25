using System;
namespace EmployeexDataAPI
{
	public class Employee
	{
		public Int64 ID { get; set; }

		public string EmployeeNumber { get; set; } = string.Empty;

		public string Name { get; set; } = string.Empty;

		public string Surname { get; set; } = string.Empty;

		public string Category { get; set; } = string.Empty;

		public string Department { get; set; } = string.Empty;

		public string SubUnit { get; set; } = string.Empty;

		public string JobTitle { get; set; } = string.Empty;

		public string WorkPlaceState { get; set; } = string.Empty;

		public string Terminated { get; set; } = string.Empty;

	}
}


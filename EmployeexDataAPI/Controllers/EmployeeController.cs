using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeexDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext context;

        public EmployeeController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(await context.tblStaff.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(Int64 id)
        {
            var employee = await context.tblStaff.FindAsync(id);
            if (employee == null)
                return BadRequest("employee not found.");
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddEmployee(Employee employee)
        {
            context.tblStaff.Add(employee);
            await context.SaveChangesAsync();
            return Ok(await context.tblStaff.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee req)
        {
            var employee = await context.tblStaff.FindAsync(req.ID);
            if (employee == null)
                return BadRequest("employee not found.");
            employee.Name = req.Name;
            employee.Surname = req.Surname;
            employee.Category = req.Category;
            employee.Department = req.Department;
            employee.SubUnit = req.SubUnit;
            employee.JobTitle = req.JobTitle;
            employee.WorkPlaceState = req.WorkPlaceState;
            employee.Terminated = req.Terminated;

            await context.SaveChangesAsync();

            return Ok(await context.tblStaff.ToListAsync());
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(Int64 id)
        {
            var employee = await context.tblStaff.FindAsync(id);
            if (employee == null)
                return BadRequest("employee not found.");

            context.tblStaff.Remove(employee);

            await context.SaveChangesAsync();

            return Ok(employee);
        }
    }
}

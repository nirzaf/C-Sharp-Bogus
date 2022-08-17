using EmployeeDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDB.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeDbContext _context;

    public EmployeeController(EmployeeDbContext context)
    {
        _context = context;
    }

    // GET API for all employees
    [HttpGet(Name="GetEmployees Details")]
    public async Task<IEnumerable<Employee>> GetAll()
    {
        List<Employee> employeeList = await _context.Employees.ToListAsync();
        return employeeList;    
    }

    // Post Employee details to database 
    [HttpPost(Name = "Create Employee Details")]
    public async Task<ActionResult<Employee>> CreateEmployee([FromBody]Employee? employee)
    {
        try
        {
            if (employee is null) return BadRequest();
            await _context.AddAsync(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }

}
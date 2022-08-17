#nullable enable
using System.ComponentModel.DataAnnotations;

namespace EmployeeDB.Models;

public class Employee
{
    [Key] public long EmployeeId { get; set;}
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Gender { get; set; }
    public int Age { get; set; }
    public float Salary { get; set; }
}
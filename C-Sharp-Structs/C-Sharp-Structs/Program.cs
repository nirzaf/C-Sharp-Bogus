var emp = new Employee
{
    Id = Int32.MinValue,
    Name = "Fazrin",
    Age = 34
};

var emp1 = new Employee
{
    Id = Int32.MinValue,
    Name = "Fazrin",
    Age = 34
};

var newEmp = new NewEmployee(3, "Fazrin", 34);
var newEmp1 = new NewEmployee(3, "Fazrin", 34);

Console.WriteLine(emp == emp1 ? "Employees are equal" : "Employees are not equal");

Console.WriteLine($"New Name {emp.Name}");
Console.ReadLine();

var empList = new List<Employee>();

// var f1 = new Faker<Employee>()
//         .RuleFor(p => p.Id, f => f.Random.Int(100, 100000))
//         .RuleFor(p => p.Name, a=>a.Person.FirstName)
//         .RuleFor(p => p.Age, a=>a.Person.DateOfBirth.Year);
//
// var randomEmployeeList = f1.Generate(100);
// empList.AddRange(randomEmployeeList);

foreach (var e in empList)
{
    Console.WriteLine($"EmpId : {e.Id}, Name: {e.Name}, Age: {e.Age}");
}

const string query= "SELECT * FROM Employee Where Id = @Id CASE Employee.Name != 'Fazrin'";

var parameters = new { Id = 3 };

Console.ReadLine();

Console.WriteLine($"{emp.Id} {emp.Name} {emp.Age}");

UserClaims claims = new UserClaims();

// this is a simple string convert to uppercase

Console.ReadLine();
public class Employee 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}


record NewEmployee(int Id, string Name, int Age); 
// public record PartTimeEmployee : Employee
// {
//     public double HourlyRate { get; set; }
//     public int HoursWorked { get; set; }
// }
//
// public record FullTimeEmployee : Employee
// {
//     public double Salary { get; set; }
// }

public struct UserClaims
{
    public string UserId { get;  }
    public string UserName { get; }
    public string Email { get; }
    public string PhoneNumber { get;  }
    public string[] Roles { get; }
}




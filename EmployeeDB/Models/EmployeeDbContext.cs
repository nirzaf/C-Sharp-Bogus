using Microsoft.EntityFrameworkCore;

namespace EmployeeDB.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base (options)
        {
                
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

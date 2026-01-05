using Microsoft.EntityFrameworkCore;

namespace Core123.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> LeaveRequests { get; set; }
    }
}

    


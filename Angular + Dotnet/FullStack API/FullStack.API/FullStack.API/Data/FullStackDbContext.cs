using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
            Employees = Set<Employee>();
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

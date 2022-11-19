using CRUDapp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUDapp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

using DropDownPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace DropDownPractice
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Department> departments { get; set; }

        public DbSet<Employee> employees { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseApp.Models;

namespace DatabaseApp.Data
{
    public class DatabaseAppContext : DbContext
    {
        public DatabaseAppContext (DbContextOptions<DatabaseAppContext> options)
            : base(options)
        {
        }

        public DbSet<DatabaseApp.Models.Employee> Employees { get; set; }
        public DbSet<DatabaseApp.Models.Department> Departments { get; set; }
    }
}

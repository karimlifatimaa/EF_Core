using ER_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ER_Core.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=USER\\SQLEXPRESS;Database=BB207_EFCore;Trusted_connection=true;Integrated security=true;Encrypt=false");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

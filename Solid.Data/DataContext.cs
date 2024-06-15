using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_API.Core.Models;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> DataEmployee { get; set; }
        public DbSet<Salary> DataSalary { get; set; }
        public DbSet<Workhours> DataWorkhours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EmployeeSystemDB");
            optionsBuilder.LogTo(message => Debug.WriteLine(message));  
        }

    }
}

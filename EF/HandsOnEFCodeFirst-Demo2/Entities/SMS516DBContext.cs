using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    internal class SMS516DBContext:DbContext
    {
        public SMS516DBContext()
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4O1D65I\SQLEXPRESS;Database=SMS516DB;trusted_connection=true");
        }
    }
}

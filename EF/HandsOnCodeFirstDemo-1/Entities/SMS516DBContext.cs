using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnCodeFirstDemo_1.Entities
{
    internal class SMS516DBContext:DbContext
    {
        public SMS516DBContext()
        {

        }
        //Define the entity set
        public DbSet<Student> Students { get; set; }
        //Define the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //set connectionstring
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4O1D65I\SQLEXPRESS;
database=SMS516DB;trusted_connection=true");
        }
    }
}

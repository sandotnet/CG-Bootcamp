using Microsoft.EntityFrameworkCore;
namespace HandsOnAPIWithEF.Entities
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext()
        {

        }
        public DbSet<Movie> Movies { get; set; } //entity set
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-4O1D65I\SQLEXPRESS;database=Movie518DB;trusted_connection=true");
        }
    }
}

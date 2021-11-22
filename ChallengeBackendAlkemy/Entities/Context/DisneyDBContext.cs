using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class DisneyDBContext : DbContext
    {
        public DisneyDBContext()
        {
            //Database.EnsureCreated();   
        }

        public DisneyDBContext(DbContextOptions<DisneyDBContext> options)
           : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<SeriesMovies> SeriesAndMovies { get; set; }


    }
}

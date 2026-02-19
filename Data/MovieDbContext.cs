using Microsoft.EntityFrameworkCore;
using Mission06_Bede.Models;

namespace Mission06_Bede.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<Movie> Movies => Set<Movie>();
    }
}

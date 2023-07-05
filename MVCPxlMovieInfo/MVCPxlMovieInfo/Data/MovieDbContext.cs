using Microsoft.EntityFrameworkCore;
using MVCPxlMovieInfo.Models.Data;

namespace MVCPxlMovieInfo.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieImage> MovieImages { get; set; }
    }
}

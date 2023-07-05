using Microsoft.EntityFrameworkCore;
using MoviePXL.Models.Data;
using System.Collections.Generic;

namespace MoviePXL.Data
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

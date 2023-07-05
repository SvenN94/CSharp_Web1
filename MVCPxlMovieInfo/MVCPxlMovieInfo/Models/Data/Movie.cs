using System.ComponentModel.DataAnnotations;

namespace MVCPxlMovieInfo.Models.Data
{
    public class Movie
    {
        public Movie()
        {
            MovieId = Guid.NewGuid().ToString();
        }
        public string MovieId { get; set;}
        [Required]
        public string MovieName { get; set;}
        public string? MovieImageId { get; set;}
        public MovieImageId? MovieImage { get; set;}
    }
}

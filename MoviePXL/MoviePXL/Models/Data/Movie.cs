using System.ComponentModel.DataAnnotations;

namespace MoviePXL.Models.Data
{
    public class Movie
    {
        public Movie()
        {
            MovieId = Guid.NewGuid().ToString();
        }
        public string MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }
        public string? MovieImageId { get; set; }
        public MovieImageId? MovieImage { get; set; }
    }
}

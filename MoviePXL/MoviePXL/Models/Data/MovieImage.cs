using System.ComponentModel.DataAnnotations;

namespace MoviePXL.Models.Data
{
    public class MovieImage
    {
        public MovieImage()
        {
            MovieImageId = Guid.NewGuid().ToString();
        }
        public string MovieImageId { get; set; }
        public byte[]? MovieImageData { get; set; }
        [Required]
        public string MovieImageName { get; set; }
        public ICollection<Movie>? Movies { get; set; }
    }
}

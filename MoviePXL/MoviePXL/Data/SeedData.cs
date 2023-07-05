using MoviePXL.Helpers;
using MoviePXL.Models.Data;

namespace MoviePXL.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MovieDbContext>();
                if (!context.MovieImages.Any())
                {
                    string filename = @"c:\foto\pulpfiction.jpg";
                    var pulpFictionImage = new MovieImage();
                    pulpFictionImage.MovieImageName = "Pulp fiction cover image";
                    pulpFictionImage.MovieImageData = FileHelper.CreateByteArrayFromFile(filename);
                    context.MovieImages.Add(pulpFictionImage);
                    var pulpFiction = new Movie();
                    pulpFiction.MovieName = "Pulp fiction";
                    pulpFiction.MovieImage = pulpFictionImage;
                    context.Movie.Add(pulpFiction);
                    context.SaveChanges();
                }
            }
        }
    }
}

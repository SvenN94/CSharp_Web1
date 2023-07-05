using Microsoft.Build.Framework;

namespace MVCVoertuig.Models.ViewModels
{
    public class RegisterViewModel 
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Pasword { get; set; }
    }
}

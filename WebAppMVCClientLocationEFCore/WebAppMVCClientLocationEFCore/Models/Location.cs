using System.ComponentModel.DataAnnotations;

namespace WebAppMVCClientLocationEFCore.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required]
        [MaxLength(15)]
        public string? PostCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string? City { get; set; }
    }
}

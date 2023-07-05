using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVCVoertuig.Models.ViewModels
{
    public class LoginViewModel
    {              
       [Required]
       public string? Email { get; set; }
       [Required]
       public string? Password { get; set; }
        
    }
}

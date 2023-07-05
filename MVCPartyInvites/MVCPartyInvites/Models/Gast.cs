﻿using System.ComponentModel.DataAnnotations;

namespace MVCPartyInvites.Models
{
    public class Gast
    {
        [Required]
        public string? Naam { get; set; }
        [Required(ErrorMessage = "Vul je e-mail in!")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Vul je telefoonnummer in!")]
        public string? Telefoon { get; set; }
        [Required(ErrorMessage = "Laat weten of je aanwezig bent!")]
        public bool? Aanwezig { get; set; }
    }
}

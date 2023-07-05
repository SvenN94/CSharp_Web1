﻿using System.ComponentModel.DataAnnotations;

namespace WebAppMVCClientLocationEFCore.Models
{
    public class Client
    {
        public int? ClientId { get; set; }

        [Required]
        public int LocationId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? ClientName { get; set; }
    }
}

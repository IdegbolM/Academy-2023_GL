﻿using System.ComponentModel.DataAnnotations;

namespace Academy_2023.Data
{
    public class User
    {
        [Required]
        public int? Id { get; set; }

        [StringLength(10)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int? Age { get; set; }
    }
}

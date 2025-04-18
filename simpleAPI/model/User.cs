﻿using System.ComponentModel.DataAnnotations;

namespace simpleAPI.model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}

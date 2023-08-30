﻿using System.ComponentModel.DataAnnotations;

namespace MM_API.Forms
{
#nullable disable
    public class RegisterForm
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(384)]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 8)]
        public string Password { get; set; }
    }
}


﻿using System.ComponentModel.DataAnnotations;

namespace WebStore.Mvc.Models
{
    public class RegisterViewModel
    {
        [Required, MinLength(4), MaxLength(256)]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}

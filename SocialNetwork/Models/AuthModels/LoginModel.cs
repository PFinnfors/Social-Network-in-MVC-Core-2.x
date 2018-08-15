﻿using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models.AuthModels
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool IsPost { get; set; }
    }
}

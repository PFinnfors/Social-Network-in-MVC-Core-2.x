using Microsoft.AspNetCore.Identity;
using System;

namespace SocialNetwork.Models.Database
{
    public class SocialUser : IdentityUser
    {
        public SocialUser(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string ImageUrl { get; set; }
    }
}

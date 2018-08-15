using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Models.Database;

namespace SocialNetwork.Data
{
    public class SocialUserContext : IdentityDbContext
    {
        public SocialUserContext(DbContextOptions<SocialUserContext> options) : base(options)
        {
        }

        public DbSet<SocialUser> SocialUsers { get; set; }
    }
}

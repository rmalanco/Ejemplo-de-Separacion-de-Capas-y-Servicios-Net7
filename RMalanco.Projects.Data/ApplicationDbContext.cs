using Microsoft.EntityFrameworkCore;
using RMalanco.Projects.Models.Entities;

namespace RMalanco.Projects.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Entities
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; } 

        // Relations
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<UsersDetails> UsersDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

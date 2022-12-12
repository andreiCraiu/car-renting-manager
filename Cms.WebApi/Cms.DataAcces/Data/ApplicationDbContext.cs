using Cms.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cms.DataAcces.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UserModel>? ApplicationUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //To get rid of an error - "The entity type 'IdentityUserLogin<long>' requires a primary key to be defined"
            base.OnModelCreating(modelBuilder);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HappyKids.Parties.Authorization.Roles;
using HappyKids.Parties.Authorization.Users;
using HappyKids.Parties.MultiTenancy;
using Abp.Localization;

namespace HappyKids.Parties.EntityFrameworkCore
{
    public class PartiesDbContext : AbpZeroDbContext<Tenant, Role, User, PartiesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PartiesDbContext(DbContextOptions<PartiesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}

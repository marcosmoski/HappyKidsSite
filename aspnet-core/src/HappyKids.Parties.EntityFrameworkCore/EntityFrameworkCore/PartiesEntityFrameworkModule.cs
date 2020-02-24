using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using HappyKids.Parties.EntityFrameworkCore.Seed;

namespace HappyKids.Parties.EntityFrameworkCore
{
    [DependsOn(
        typeof(PartiesCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class PartiesEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PartiesDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        PartiesDbContextConfigurerPostgres.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        PartiesDbContextConfigurerPostgres.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PartiesEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HappyKids.Parties.Authorization;

namespace HappyKids.Parties
{
    [DependsOn(
        typeof(PartiesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PartiesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PartiesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PartiesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

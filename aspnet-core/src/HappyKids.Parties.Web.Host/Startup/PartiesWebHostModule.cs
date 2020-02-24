using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HappyKids.Parties.Configuration;

namespace HappyKids.Parties.Web.Host.Startup
{
    [DependsOn(
       typeof(PartiesWebCoreModule))]
    public class PartiesWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PartiesWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PartiesWebHostModule).GetAssembly());
        }
    }
}

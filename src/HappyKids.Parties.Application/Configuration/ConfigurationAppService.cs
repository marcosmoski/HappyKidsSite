using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HappyKids.Parties.Configuration.Dto;

namespace HappyKids.Parties.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PartiesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using HappyKids.Parties.Configuration.Dto;

namespace HappyKids.Parties.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

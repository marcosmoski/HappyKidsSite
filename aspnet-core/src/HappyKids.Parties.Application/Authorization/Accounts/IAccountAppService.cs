using System.Threading.Tasks;
using Abp.Application.Services;
using HappyKids.Parties.Authorization.Accounts.Dto;

namespace HappyKids.Parties.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

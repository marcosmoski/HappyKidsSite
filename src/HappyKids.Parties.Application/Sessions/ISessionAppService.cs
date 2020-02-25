using System.Threading.Tasks;
using Abp.Application.Services;
using HappyKids.Parties.Sessions.Dto;

namespace HappyKids.Parties.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HappyKids.Parties.MultiTenancy.Dto;

namespace HappyKids.Parties.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


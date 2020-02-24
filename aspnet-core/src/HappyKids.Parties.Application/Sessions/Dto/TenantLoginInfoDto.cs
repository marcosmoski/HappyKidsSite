using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HappyKids.Parties.MultiTenancy;

namespace HappyKids.Parties.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

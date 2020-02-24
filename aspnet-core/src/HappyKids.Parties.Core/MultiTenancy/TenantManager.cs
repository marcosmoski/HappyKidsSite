using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using HappyKids.Parties.Authorization.Users;
using HappyKids.Parties.Editions;

namespace HappyKids.Parties.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}

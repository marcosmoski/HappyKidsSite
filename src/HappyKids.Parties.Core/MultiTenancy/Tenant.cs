using Abp.MultiTenancy;
using HappyKids.Parties.Authorization.Users;

namespace HappyKids.Parties.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

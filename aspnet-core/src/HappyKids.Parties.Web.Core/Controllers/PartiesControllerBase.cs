using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HappyKids.Parties.Controllers
{
    public abstract class PartiesControllerBase: AbpController
    {
        protected PartiesControllerBase()
        {
            LocalizationSourceName = PartiesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

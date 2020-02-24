using Abp.Authorization;
using HappyKids.Parties.Authorization.Roles;
using HappyKids.Parties.Authorization.Users;

namespace HappyKids.Parties.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Microsoft.AspNetCore.Antiforgery;
using HappyKids.Parties.Controllers;

namespace HappyKids.Parties.Web.Host.Controllers
{
    public class AntiForgeryController : PartiesControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

using Abp.AutoMapper;
using HappyKids.Parties.Authentication.External;

namespace HappyKids.Parties.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

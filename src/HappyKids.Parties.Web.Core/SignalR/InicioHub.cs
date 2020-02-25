using Abp.Web.SignalR;
using Abp.Dependency;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace HappyKids.Parties.Web.Core.SignalR
{
    public class InicioHub : Microsoft.AspNetCore.SignalR.Hub, ITransientDependency
    {
         public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
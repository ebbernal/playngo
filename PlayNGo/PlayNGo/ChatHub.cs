using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace PlayNGo.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessageToCaller(string message)
        {
            return Clients.Caller.SendAsync("ReceiveMessage", message);
        }
    }
}   
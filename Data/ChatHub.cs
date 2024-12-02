using Microsoft.AspNetCore.SignalR;

namespace Real_Time_Chat_Application_SignalIR.Data
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Broadcast the message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

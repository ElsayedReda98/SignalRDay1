using Microsoft.AspNetCore.SignalR;

namespace SignalRDay1.Hubs
{
    // naming convention end with Hub 
    public class ChatHub : Hub
    {
        // most functions return void
        public async void SendMessage(string name, string message)
        {
            // save msg in db

            // broadcasting msg for all online clients
            // newMessage -> is an event name
            await Clients.All.SendAsync("newMessage", name, message);
        }
    }
}

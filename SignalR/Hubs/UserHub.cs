using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class UserHub : Hub
    {
        public static int TotalViews { get; set; } = 0;
        public async Task NewWindowLoaded()
        {
            TotalViews++;
            // Send the new total to all clients
            await Clients.All.SendAsync("ReceiveMessage", TotalViews);
        }
    }
}

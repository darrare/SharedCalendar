using Microsoft.AspNetCore.SignalR;

namespace SharedCalendar.Hubs
{
    public class CalendarHub : Hub
    {
        public async Task NotifyEventChanged()
        {
            Console.WriteLine("NotifyEventChanged has been called!");
            try
            {
                await Clients.All.SendAsync("ReceiveEventUpdate");
            }
            catch (Exception ex)
            {
                // Ideally use a logger here, for now just rethrow to see if you catch the error on the client
                Console.WriteLine(ex.Message);
                throw new HubException("Error sending event update", ex);
            }
        }
    }
}

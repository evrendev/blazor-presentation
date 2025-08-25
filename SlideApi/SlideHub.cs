using Microsoft.AspNetCore.SignalR;

namespace SlideApi
{
    public class SlideHub : Hub
    {
        public async Task SendSlideNumber(int slideNumber)
        {
            await Clients.All.SendAsync("ReceiveSlideNumber", slideNumber);
        }
    }
}

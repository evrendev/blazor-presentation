namespace PublicApi
{
    public class SlideHub : Hub
    {
        public async Task SendSlideNumber(int slideNumber)
        {
            await Clients.All.SendAsync("ReceiveSlideNumber", slideNumber);
        }

        public async Task JoinPresentation(string presentationId = "default")
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, presentationId);
            await Clients.Group(presentationId).SendAsync("UserJoined", Context.ConnectionId);
        }

        public async Task LeavePresentation(string presentationId = "default")
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, presentationId);
            await Clients.Group(presentationId).SendAsync("UserLeft", Context.ConnectionId);
        }

        public async Task SendSlideToGroup(int slideNumber, string presentationId = "default")
        {
            await Clients.Group(presentationId).SendAsync("ReceiveSlideNumber", slideNumber);
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
            // Varsayılan olarak default grubuna ekle
            await JoinPresentation("default");
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await LeavePresentation("default");
            await base.OnDisconnectedAsync(exception);
        }
    }
}

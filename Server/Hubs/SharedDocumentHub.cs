using Microsoft.AspNetCore.SignalR;

namespace LikeNotion.Server.Hubs
{
    public class SharedDocumentHub : Hub
    {
        public async Task UpdateDocumentContent(string content)
        {
            await Clients.All.SendAsync("ReceiveDocumentContent", content);
        }
    }
}

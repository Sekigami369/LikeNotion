using Microsoft.AspNetCore.SignalR;

namespace LikeNotion.Server.Models
{
    public class SharedDocuHub : Hub
    {
        public async Task UpdateDocuContent(string content)
        {
            await Clients.All.SendAsync("ReceiveDocumentContent", content);
        }
    }
}

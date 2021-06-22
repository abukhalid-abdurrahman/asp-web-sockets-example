using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebSockets.Services
{
    public class SocketsHandler : ISocketsHandler
    {
        public Task Handle(HttpContext context, WebSocket webSocket)
        {
            throw new System.NotImplementedException();
        }
    }
}
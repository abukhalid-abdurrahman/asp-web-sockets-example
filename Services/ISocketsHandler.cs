using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebSockets.Services
{
    public interface ISocketsHandler
    {
        Task Handle(HttpContext context, WebSocket webSocket);
    }
}
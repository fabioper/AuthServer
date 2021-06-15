using System.Threading.Tasks;
using AuthServer.Services.Messages;

namespace AuthServer.Services.Contracts
{
    public interface IEventBus
    {
        Task Publish(EventMessage message);
    }
}
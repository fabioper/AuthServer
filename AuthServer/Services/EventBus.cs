using System;
using System.Threading.Tasks;
using AuthServer.Services.Contracts;
using AuthServer.Services.Messages;
using MassTransit;

namespace AuthServer.Services
{
    public class EventBus : IEventBus
    {
        private readonly IBus _bus;

        public EventBus(IBus bus) => _bus = bus;

        public async Task Publish(EventMessage message)
        {
            var address = $"queue:{message.QueueName()}";
            var endpoint = await _bus.GetSendEndpoint(new Uri(address));
            await endpoint.Send(message);
        }
    }
}
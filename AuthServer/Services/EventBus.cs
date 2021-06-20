using System.Text;
using System.Threading.Tasks;
using AuthServer.Services.Contracts;
using AuthServer.Services.Messages;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace AuthServer.Services
{
    public class EventBus : IEventBus
    {
        public Task Publish(EventMessage message)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };

            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            var queue = message.QueueName();
            channel.QueueDeclare(queue, false, false, false, null);

            var serializedMessage =  JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(serializedMessage);
            
            channel.BasicPublish("", queue, false, null, body);

            return Task.CompletedTask;
        }
    }
}
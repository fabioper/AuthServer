namespace AuthServer.Services.Messages
{
    public abstract class EventMessage
    {
        public abstract string QueueName();
    }
}
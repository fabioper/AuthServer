namespace AuthServer.Services.Messages
{
    public class UserCreated : EventMessage
    {
        public override string QueueName() => "user-created";
        public string UserId { get; set; }
        public string Name { get; set; }

        public UserCreated(string userId, string name)
        {
            UserId = userId;
            Name = name;
        }
    }
}
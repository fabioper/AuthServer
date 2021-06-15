using System;

namespace AuthServer.Services.Messages
{
    public class UserCreated : EventMessage
    {
        public override string QueueName() => "user-created";
        
        public Guid Id = Guid.NewGuid();
        public string UserId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserCreated(string userId, string username, DateTime createdAt)
        {
            UserId = userId;
            Username = username;
            CreatedAt = createdAt;
        }
    }
}
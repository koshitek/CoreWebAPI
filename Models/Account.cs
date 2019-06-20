using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreWebAPI
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Message> messages { get; set; }
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
using HabibiTeaTime.HttpRequest.Enums;

namespace HabibiTeaTime.HttpRequest.Models
{
    public class Chatter
    {
        public string Username { get; }

        public ChatRole ChatRole { get; }

        public Chatter(string username, ChatRole chatRole)
        {
            Username = username;
            ChatRole = chatRole;
        }

        public override string ToString()
        {
            return Username;
        }
    }
}

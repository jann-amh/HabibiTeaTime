#nullable disable

using HLE.Time;

namespace HabibiTeaTime.Database.Models
{
    public partial class Message
    {
        public Message(string username, string channel, byte[] message1)
        {
            Username = username;
            Channel = channel;
            Message1 = message1;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Channel { get; set; }
        public byte[] Message1 { get; set; }
        public long Time { get; set; } = TimeHelper.Now();
    }
}

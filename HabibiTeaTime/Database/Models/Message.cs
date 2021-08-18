#nullable disable

namespace HabibiTeaTime.Database.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Channel { get; set; }
        public byte[] Message1 { get; set; }
        public long Time { get; set; }
    }
}

#nullable disable

namespace HabibiTeaTime.Database.Models
{
    public partial class Bot
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Channels { get; set; }
    }
}

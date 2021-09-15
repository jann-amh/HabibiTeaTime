using HabibiTeaTime.Properties;
using System.Collections.Generic;
using System.Linq;

namespace HabibiTeaTime.Twitch
{
    public static class Config
    {
        public const string Prefix = "~";
        public const int MaxMessageLength = 500;
        public const int MinimumDelayBetweenMessages = 1300;
        public static List<string> GetChannels()
        {
            return Resources.Channels.Split().ToList();
        }
    }
}

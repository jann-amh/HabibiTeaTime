using HabibiTeaTime.Properties;
using System.Collections.Generic;
using System.Linq;

namespace HabibiTeaTime.Twitch
{
    public static class Config
    {
        public const string Prefix = "~";

        public static List<string> GetChannels()
        {
            return Resources.Channels.Split().ToList();
        }
    }
}

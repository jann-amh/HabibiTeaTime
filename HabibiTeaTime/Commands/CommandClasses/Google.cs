using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Google
    {
        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            twitchBot.Send(chatMessage.Channel, $"Habibi TeaTime Hey {chatMessage.Username} , this is your requested search {HLE.Emojis.Emoji.PointRight} {GetUrl(chatMessage.Message)}");
        }

        private static string GetUrl(string message)
        {

            string baseurl = "https://www.google.com/search?q=";
            foreach (string s in message.Split()[1..])
            {
                baseurl += $"{s}+";
            }
            return baseurl[..^1];
        }
    }
}

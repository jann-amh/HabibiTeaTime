using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Ping
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"{bot.SendPing(bot)}");
        }
    }
}

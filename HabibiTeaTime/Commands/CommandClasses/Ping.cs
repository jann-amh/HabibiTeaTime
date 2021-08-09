using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Ping
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"/me Habibi TeaTime Pong! Runtime: {bot.Runtime} ");
        }
    }
}

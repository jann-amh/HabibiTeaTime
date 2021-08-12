using HabibiTeaTime.Twitch;
using HLE.Emojis;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Chatterino
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"{chatMessage.Username}, This is the current Chatterino7 version {Emoji.PointRight} https://github.com/SevenTV/chatterino7/releases");
        }
    }
}

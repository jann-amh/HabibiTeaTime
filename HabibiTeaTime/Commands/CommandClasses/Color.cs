using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Color
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"/me Habibi TeaTime {chatMessage.Username} your color is: {chatMessage.ColorHex} / {chatMessage.Color}");
        }
    }
}

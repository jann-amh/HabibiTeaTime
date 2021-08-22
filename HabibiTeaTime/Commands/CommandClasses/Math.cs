using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Math
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            bot.SendMathResult(chatMessage);
        }
        private static void SendMathResult(this TwitchBot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"/me {chatMessage.Username}, {HttpRequest.HttpRequest.GetMathResult(chatMessage.Message[(chatMessage.Message.Split()[0].Length + 1)..])}");
        }
    }
}

using HabibiTeaTime.JsonData;
using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class YourMom
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.Message.Split().Length == 1)
            {
                bot.Send(chatMessage.Channel, $"{chatMessage.Username} {JsonController.GetRrandomJoke()}");
            }
            else
            {
                bot.Send(chatMessage.Channel, $"{chatMessage.Message.Split()[1]} {JsonController.GetRrandomJoke()}");
            }
        }
    }
}

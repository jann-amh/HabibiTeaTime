using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Help
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"/me Habibi TeaTime {chatMessage.Username} here you can find a list of commands and the repository: https://github.com/jann-amh/HabibiTeaTime");
        }
    }
}

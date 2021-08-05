using HabibiTeaTime.Commands;
using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Messages
{
    public static class MessageHandler
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            CommandHandler.Handle(bot, chatMessage);
        }
    }
}
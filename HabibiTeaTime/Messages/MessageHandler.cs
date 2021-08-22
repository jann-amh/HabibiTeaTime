using HabibiTeaTime.Commands;
using HabibiTeaTime.Commands.PassiveActions;
using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Messages
{
    public static class MessageHandler
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            CommandHandler.Handle(bot, chatMessage);
            BenAstro.Handle(bot, chatMessage);
        }
    }
}
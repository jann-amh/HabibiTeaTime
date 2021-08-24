using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class MessageInterruptions
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.Message == "Habibi TeaTime")
            {
                bot.Send(chatMessage.Channel, "Habibi TeaTime");
            }

            if (chatMessage.Message == "forsen1 forsen2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");
            }

            if (chatMessage.Channel == "poki1 poki2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");
            }

            if (chatMessage.Channel == "md7V1 md7V2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");

            }
        }
    }
}

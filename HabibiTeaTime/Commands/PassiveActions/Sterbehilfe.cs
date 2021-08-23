using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class Sterbehilfe
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.Username == "Strbhlfe")
            {
                bot.Send(chatMessage.Channel, HLE.Emojis.Emoji.NerdFace);
            }
        }
    }
}

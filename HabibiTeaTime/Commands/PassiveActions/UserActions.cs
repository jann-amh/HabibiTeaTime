using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class UserActions
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.Username == "strbhlfe")
            {
                bot.Send(chatMessage.Channel, HLE.Emojis.Emoji.NerdFace);
            }

            if (chatMessage.Username == "benastro")
            {
                bot.Send(chatMessage.Channel, $"BatChest {HLE.Emojis.Emoji.MiddleFinger}");
            }

            if (chatMessage.Username == "lisaseltern")
            {
                bot.Send(chatMessage.Channel, $"TriHard {HLE.Emojis.Emoji.MiddleFinger} {HLE.Emojis.Emoji.PointUp}");
            }
        }
    }
}

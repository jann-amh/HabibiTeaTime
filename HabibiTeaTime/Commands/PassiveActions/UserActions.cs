using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class UserActions
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {

            if (chatMessage.Username == "lisaseltern")
            {
                bot.Send(chatMessage.Channel, $"TriHard {HLE.Emojis.Emoji.MiddleFinger} {HLE.Emojis.Emoji.PointUp}");
            }
        }
    }
}

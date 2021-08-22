using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class BenAstro
    {
        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            if (chatMessage.Username == "benastro")
            {
                twitchBot.Send(chatMessage.Channel, $"BatChest {HLE.Emojis.Emoji.MiddleFinger}");
            }
        }
    }
}

using System.Linq;
using HabibiTeaTime.Twitch;
using HLE.Strings;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class ASCIIConverter
    {


        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            if (chatMessage.Message.Split()[1].All(char.IsDigit))
            {
                int i = chatMessage.Message.Split()[1].ToInt();
                twitchBot.Send(chatMessage.Channel, $"/me Habibi TeaTime Hey {chatMessage.Username}, this is your requested ASCII {HLE.Emojis.Emoji.PointRight}{GetChar(i)}");
            }
            else
            {
                twitchBot.Send(chatMessage.Channel, $"/me Habibi TeaTime enter a valid number {HLE.Emojis.Emoji.Anger}");
            }
        }

        private static char GetChar(int i)
        {
            return (char)i;
        }
    }
}

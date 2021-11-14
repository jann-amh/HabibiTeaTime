using HabibiTeaTime.Twitch;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Pyramid
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            int width = 3;
            if (chatMessage.Message.Split().Length.Equals(2))
            {
                string emote = chatMessage.Message.Split()[1];
                for (int i = 1; i < width; i++)
                {
                    bot.Send(chatMessage.Channel, SendPyramid(i, emote));
                }

                for (int i = width; i > 0; i--)
                {
                    bot.Send(chatMessage.Channel, SendPyramid(i, emote));
                }
            }
            else
            {
                bot.Send(chatMessage.Channel, $"{chatMessage.Username} You have to type a single emote {HLE.Emojis.Emoji.Anger}");
            }

        }
        private static string SendPyramid(int count, string emote)
        {
            string result = emote;
            for (int i = 1; i < count; i++)
            {
                result += $" {emote}";
            }
            return result;
        }
    }
}

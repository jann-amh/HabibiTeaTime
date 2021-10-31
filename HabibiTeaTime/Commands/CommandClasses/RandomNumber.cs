using System.Text.RegularExpressions;
using HabibiTeaTime.Twitch;
using HLE.Randoms;
using HLE.Strings;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class RandomNumber
    {
        private static int GetRandom(ChatMessage chatMessage)
        {
            string[] split = chatMessage.Message.Split();
            int min = split[1].ToInt();
            int max = split[2].ToInt();
            return Random.Int(min, max);
        }

        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if(chatMessage.Message.Split()[1].All(char.IsDigit))
            {
                if (chatMessage.Message.IsMatch(@"^" + Regex.Escape(Config.Prefix) + @"\w+\s-?\d+\s-?\d+"))
                {

                bot.Send(chatMessage.Channel, $"/me {GetRandom(chatMessage)}");
                }
                else
                {
                bot.Send(chatMessage.Channel, $"/me {Random.Int()}");
                }
            }
            else
            {
                bot.Send(chatMessage.Channel, $"/me @{chatMessage.Username}, the number may not be a comma number and must be positive!")
            }
        }
    }
}

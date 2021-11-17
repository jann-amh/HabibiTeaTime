using System;
using System.Text.RegularExpressions;
using HabibiTeaTime.Twitch;
using HLE.Strings;
using TwitchLib.Client.Models;
using Random = HLE.Random.Random;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class RandomNumber
    {
        private static readonly Regex _numberRegex = new($@"^{Regex.Escape(Config.Prefix)}\w+\s+-?\d+\s+-?\d+(\s|$)", RegexOptions.IgnoreCase | RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        private static int? GetRandom(ChatMessage chatMessage)
        {
            try
            {
                string[] split = chatMessage.Message.TrimAll().Split();
                int min = split[1].ToInt();
                int max = split[2].ToInt();
                return Random.Int(min, max);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            int? randomNumber = null;
            if (_numberRegex.IsMatch(chatMessage.Message))
            {
                randomNumber = GetRandom(chatMessage);
            }

            if (randomNumber is not null)
            {
                bot.Send(chatMessage.Channel, $"/me {randomNumber}");
            }
            else
            {
                bot.Send(chatMessage.Channel, $"/me {Random.Int()}");
            }
        }
    }
}

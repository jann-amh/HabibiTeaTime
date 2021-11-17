using HabibiTeaTime.Twitch;
using HLE.Emojis;
using HLE.Random;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Coinflip
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            SendCoinFlip(bot, chatMessage);
        }
        private static void SendCoinFlip(TwitchBot bot, ChatMessage chatMessage)
        {
            string result = Random.Int(0, 100) >= 50 ? "yes/heads" : "no/tails";
            bot.Send(chatMessage.Channel, $"/me {chatMessage.Username}, {result} {Emoji.Coin}");
        }
    }
}

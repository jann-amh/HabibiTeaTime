using HabibiTeaTime.Twitch;
using HLE.Emojis;
using HLE.Randoms;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Coinflip
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            SendCoinFlip(bot, chatMessage);
        }
        private static void SendCoinFlip(Bot bot, ChatMessage chatMessage)
        {
            string result = Random.Int(0, 100) >= 50 ? "yes/heads" : "no/tails";
            bot.Send(chatMessage.Channel, $"{chatMessage.Username}, {result} {Emoji.Coin}");
        }
    }
}

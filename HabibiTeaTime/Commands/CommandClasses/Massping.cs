using HabibiTeaTime.HttpRequest.Models;
using HabibiTeaTime.Messages;
using HabibiTeaTime.Twitch;
using HLE.Emojis;
using System.Collections.Generic;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Massping
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.IsModOrBroadcaster() || chatMessage.Username == "jann_amh_")
            {
                SendMassping(bot, chatMessage);
            }

        }

        private static void SendMassping(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            List<Chatter> chatters = HttpRequest.HttpRequest.GetChatters(chatMessage.Channel);
            string result = string.Empty;
            chatters.ForEach(c =>
            {
                result += $"{c} BatChest / {Emoji.Bell}";
            });
            DividedMessage dividedMessage = new(twitchBot, chatMessage.Channel, result);
            dividedMessage.StartSending();
        }
    }
}

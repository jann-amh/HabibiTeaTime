using HabibiTeaTime.HttpRequest.Models;
using HabibiTeaTime.Messages;
using HabibiTeaTime.Twitch;
using System.Collections.Generic;
using TwitchLib.Client.Models;
using HLE.Emojis;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Massping
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, SendMassping(chatMessage));
        }

        private static string SendMassping(ChatMessage chatMessage)
        {
            if (chatMessage.IsModOrBroadcaster())
            {
                List<Chatter> chatters = HttpRequest.HttpRequest.GetChatters(chatMessage.Channel);
                string result = string.Empty;
                chatters.ForEach(c =>
                {
                    result += $" {c} BatChest / {Emoji.Bell}";
                });
                return result.Trim();
            }
            else
            {
                return $"{chatMessage.Username}, you aren't a mod or the broadcaster";
            }

        }
    }
}

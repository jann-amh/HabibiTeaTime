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
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, SendMassping(chatMessage));
        }

        private static string SendMassping(ChatMessage chatMessage)
        {
            if (chatMessage.IsModOrBroadcaster() || chatMessage.Username == "jann_amh_")
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
                return $"/me{chatMessage.Username}, you aren't a mod or the broadcaster";
            }

        }
    }
}
using HabibiTeaTime.Twitch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;
using HLE.Emojis;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Chatterino
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            bot.Send(chatMessage.Channel, $"{chatMessage.Username}, This is the current Chatterino7 version {Emoji.PointRight} https://github.com/SevenTV/chatterino7/releases");
        }
    }
}

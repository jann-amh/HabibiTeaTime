﻿using HabibiTeaTime.Properties;
using HabibiTeaTime.Twitch;
using HLE.Emojis;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.PassiveActions
{
    public static class MessageInterruptions
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            if (chatMessage.Message == "Habibi TeaTime")
            {
                bot.Send(chatMessage.Channel, "Habibi TeaTime");
            }

            if (chatMessage.Message == "forsen1 forsen2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");
            }

            if (chatMessage.Channel == "poki1 poki2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");
            }

            if (chatMessage.Channel == "md7V1 md7V2")
            {
                bot.Send(chatMessage.Channel, "no, i dont think so");

            }

            if (chatMessage.Username == "pajbot" && chatMessage.Message == "pajaS 🚨 ALERT")
            {
                bot.Send(chatMessage.Channel, $"peepoSpookDank {Emoji.RotatingLight} ACHTUNG !");
                bot.Send(Resources.Offlinechat, $".me jannGIGA {Emoji.RotatingLight} ALERT {Emoji.Exclamation}");
            }
        }
    }
}

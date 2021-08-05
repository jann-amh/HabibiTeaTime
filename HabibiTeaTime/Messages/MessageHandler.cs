using HabibiTeaTime.Twitch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Messages
{
    public static class MessageHandler
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        { 
            CommandHandler.Handle(bot, chatMessage);
        }
    }
}
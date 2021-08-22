using HabibiTeaTime.Twitch;
using System;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class Vanish
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            bot.TwitchClient.TimeoutUser(chatMessage.Channel, chatMessage.Username, TimeSpan.FromSeconds(1));
        }
    }
}

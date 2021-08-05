﻿using HabibiTeaTime.JsonData;
using HabibiTeaTime.Twitch;
using HLE.Strings;
using System;
using System.Text.RegularExpressions;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands
{
    public static class CommandHandler
    {
        public static void Handle(Bot bot, ChatMessage chatMessage)
        {
            foreach (Command command in JsonController.CommandData.Commands)
            {
                foreach (string alias in command.Alias)
                {
                    if (chatMessage.Message.IsMatch(@"^" + Regex.Escape(Config.Prefix) + alias + @"(\s|$)"))
                    {
                        Type.GetType($"HabibiTeaTime.Commands.CommandClasses.{FirstCharToUppercase(command.CommandName)}").GetMethod("Handle").Invoke(null, new object[] { bot, chatMessage });
                    }
                }
            }
        }

        private static string FirstCharToUppercase(string str)
        {
            return $"{str[0]}".ToUpper() + str[1..];
        }
    }
}
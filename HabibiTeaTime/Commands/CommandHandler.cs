using System;
using System.Text.RegularExpressions;
using HabibiTeaTime.Commands.Enums;
using HabibiTeaTime.JsonData;
using HabibiTeaTime.Twitch;
using HLE.Enums;
using HLE.Strings;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands
{
    public static class CommandHandler
    {
        public static void Handle(TwitchBot bot, ChatMessage chatMessage)
        {
            foreach (CommandType commandType in typeof(CommandType).ToArray<CommandType>())
            {
                if (!bot.IsOnCooldown(chatMessage.Username, commandType))
                {
                    foreach (string alias in JsonController.GetCommand(commandType).Alias)
                    {
                        if (chatMessage.Message.IsMatch(@"^" + Regex.Escape(Config.Prefix) + alias + @"(\s|$)"))
                        {
                            Type.GetType($"HabibiTeaTime.Commands.CommandClasses.{commandType}").GetMethod("Handle").Invoke(null, new object[] { bot, chatMessage });
                            bot.AddCooldown(chatMessage.Username, commandType);
                            break;
                        }
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

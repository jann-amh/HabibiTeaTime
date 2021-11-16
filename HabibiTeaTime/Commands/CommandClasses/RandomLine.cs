using HabibiTeaTime.Database.Models;
using HabibiTeaTime.Exceptions;
using HabibiTeaTime.Twitch;
using HabibiTeaTime.Utils;
using HLE.Strings;
using HLE.Time;
using HLE.Time.Enums;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses
{
    public static class RandomLine
    {
        public static string SendRandomMessage(ChatMessage chatMessage)
        {
            try
            {
                if (chatMessage.Message.Split().Length > 2)
                {
                    Message message = TwitchBot.GetRandomMessage(chatMessage.Message.ToLower().Split()[1], chatMessage.Message.ToLower().Split()[2].RemoveHashtag());
                    return $"({message.Channel} | {TimeHelper.ConvertUnixTimeToTimeStamp(message.Time, "ago", ConversionType.YearDayHour)}) {message.Username}: {message.Message1.Decode()}";
                }
                else if (chatMessage.Message.Split().Length > 1)
                {
                    Message message = TwitchBot.GetRandomMessage(chatMessage.Message.ToLower().Split()[1]);
                    return $"({TimeHelper.ConvertUnixTimeToTimeStamp(message.Time, "ago", ConversionType.YearDayHour)}) {message.Username}: {message.Message1.Decode()}";
                }
                else
                {
                    Message message = TwitchBot.GetRandomMessage(chatMessage);
                    return $"({TimeHelper.ConvertUnixTimeToTimeStamp(message.Time, "ago", ConversionType.YearDayHour)}) {message.Username}: {message.Message1.Decode()}";
                }
            }
            catch (MessageNotFoundException ex)
            {
                return $"{chatMessage.Username}, {ex.Message}";
            }
        }

        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            twitchBot.Send(chatMessage.Channel, SendRandomMessage(chatMessage));
        }
    }
}

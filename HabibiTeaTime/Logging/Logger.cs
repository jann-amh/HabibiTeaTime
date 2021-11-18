using System;
using System.IO;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Logging
{
    public static class Logger
    {
        public static void Log(string text)
        {
            LogToFile(text);
        }

        public static void Log(ChatMessage chatMessage)
        {
            LogToFile($"#{chatMessage.Channel}>{chatMessage.Username}: {chatMessage.Message}");
        }

        public static void Log(Exception ex)
        {
            LogToFile($"{ex.GetType().Name}: {ex.Message}: {ex.StackTrace}");
        }

        private static string CreateLog(string input)
        {
            return $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} | {input}{Environment.NewLine}";
        }

        private static void LogToFile(string log)
        {
            File.AppendAllText("./Resources/Logs.log", CreateLog(log));
        }
    }
}

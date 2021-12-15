using System;
using System.Diagnostics;
using System.Threading;
using HabibiTeaTime.JsonData;
using HabibiTeaTime.Logging;
using HabibiTeaTime.Twitch;

namespace HabibiTeaTime
{
    public class Program
    {
        public static event EventHandler Restarting;
        private static void Main(string[] args)
        {
            JsonController.LoadData();
            _ = new Twitch​Bot();

            while (true)
            {
                Thread.Sleep(1000);
            }

        }
        public static void Restart()
        {
            Restarting?.Invoke(new object(), new());
            Logger.Log("Bot Restartet.");
            Console.WriteLine($"Bot restarted.");
            Process.Start($"./HabibiTeaTime");
            Environment.Exit(0);
        }
    }
}

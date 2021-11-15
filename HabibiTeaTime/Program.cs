using System;
using System.Diagnostics;
using System.Threading;
using HabibiTeaTime.JsonData;
using HabibiTeaTime.Twitch;

namespace HabibiTeaTime
{
    public class Program
    {
        private static void Main(string[] args)
        {
            JsonController.LoadData();
            _ = new TwitchBot();

            while (true)
            {
                Thread.Sleep(1000);
            }

        }
        public void Restart()
        {
            Console.WriteLine($"Bot restarted.");
            Process.Start($"./HabibiTeaTime");
            Environment.Exit(0);
        }
    }
}

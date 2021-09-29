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

            }
        }
    }
}

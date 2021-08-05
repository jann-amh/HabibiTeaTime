using System.IO;
using System.Text.Json;

namespace HabibiTeaTime.JsonData
{
    public class JsonController
    {
        public static CommandData CommandData { get; private set; }

        public static void LoadData()
        {
            CommandData = JsonSerializer.Deserialize<CommandData>(File.ReadAllText("./Resources/Commands.json"));
        }
    }
}

using System.IO;
using System.Linq;
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

        public static Command GetCommand(string name)
        {
            return CommandData.Commands.FirstOrDefault(c => c.CommandName.ToLower() == name.ToLower());
        }
    }
}

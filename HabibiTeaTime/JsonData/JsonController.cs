using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using HabibiTeaTime.Commands.Enums;
using HLE.Collections;

namespace HabibiTeaTime.JsonData
{
    public class JsonController
    {
        public static CommandData CommandData { get; private set; }

        public static List<string> Yourmom { get; private set; }

        public static void LoadData()
        {
            CommandData = JsonSerializer.Deserialize<CommandData>(File.ReadAllText("./Resources/Commands.json"));
            Yourmom = JsonSerializer.Deserialize<List<string>>(File.ReadAllText("./Resources/YourMom.json"));
        }

        public static Command GetCommand(CommandType name)
        {
            return CommandData.Commands.FirstOrDefault(c => c.CommandName.ToLower() == name.ToString().ToLower());
        }

        public static string GetRrandomJoke()
        {
            return Yourmom.Random();
        }
    }
}

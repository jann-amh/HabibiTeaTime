using System.Collections.Generic;

namespace HabibiTeaTime.JsonData
{
    public class Command
    {
        public string CommandName { get; set; }

        public List<string> Alias { get; set; }

        public int Cooldown { get; set; }
    }
}

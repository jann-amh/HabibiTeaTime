﻿using HabibiTeaTime.Commands.Enums;
using HabibiTeaTime.JsonData;
using HLE.Time;

namespace HabibiTeaTime.Twitch.Cooldowns
{
    public class Cooldown
    {
        public string Username { get; }

        public CommandType Type { get; }

        public long Time { get; private set; }

        public Cooldown(string username, CommandType type)
        {
            Username = username;
            Type = type;
            Time = TimeHelper.Now() + JsonController.GetCommand(type).Cooldown;
        }

        public override bool Equals(object obj)
        {
            return obj is Cooldown cooldown && cooldown.Username == Username && cooldown.Type == Type;
        }
    }
}

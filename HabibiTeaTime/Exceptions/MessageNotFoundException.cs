﻿using System;

namespace HabibiTeaTime.Exceptions
{
    public class MessageNotFoundException : Exception
    {
        public override string Message { get; } = "could not find any matching message";

        public MessageNotFoundException() : base()
        {
        }

        public MessageNotFoundException(string message) : base(message)
        {
        }
    }
}

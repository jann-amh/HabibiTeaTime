using System;
using HabibiTeaTime.Twitch;
using HLE.Collections;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses;

public static class GachiSlots
{
    public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
    {
        if (chatMessage.Channel != Properties.Resources.Offlinechat)
        {
            return;
        }

        string[] arr =
        {
            "Gachi", "gachiDance", "gachiBOP", "gachiHop", "gachiHug", "gachiRoll", "gachiPRIDE", "gachiAlien", "gachiFeels", "gachiJann", "GachiPls", "gachiWelcome", "gachiBASS", "gachiGASM"
        };

        string[] rndm = new string[3];

        for (int i = 0; i < rndm.Length; i++)
        {
            rndm[i] = arr.Random();
        }

        twitchBot.Send(chatMessage.Channel, $"/me Habibi TeaTime [ {String.Join(' ', rndm)} ]");
    }
}

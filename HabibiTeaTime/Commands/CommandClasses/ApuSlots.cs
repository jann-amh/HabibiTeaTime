using System;
using HabibiTeaTime.Twitch;
using HLE.Collections;
using TwitchLib.Client.Models;

namespace HabibiTeaTime.Commands.CommandClasses;

public static class ApuSlots
{   
    public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
    {
        if (chatMessage.Channel != Properties.Resources.Offlinechat)
        {
            return;
        }

        string[] arr = {"APU", "ApuJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAM", "ApuSpin", "ApuJam", "ApuSquats", "ApuNotSure", "ApuCool", "ApuReady", "ApuHug", "ApuY","ApuNerd", "ApuApproved"};

        string[] rndm = new string[3];

        for (var i = 0; i < rndm.Length; i++)
        {
            rndm[i] = arr.Random();
        }

        twitchBot.Send(chatMessage.Channel, $"/me Habibi TeaTime [ {String.Join(' ', rndm)} ]");
    }
}

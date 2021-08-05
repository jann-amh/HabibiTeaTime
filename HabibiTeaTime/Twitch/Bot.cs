using HabibiTeaTime.Messages;
using HabibiTeaTime.Properties;
using System;
using TwitchLib.Client;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Enums;
using TwitchLib.Communication.Models;
using static HLE.Time.TimeHelper;

namespace HabibiTeaTime.Twitch
{
    public class Bot
    {
        public TwitchClient TwitchClient { get; private set; }

        public ConnectionCredentials ConnectionCredentials { get; private set; }

        public ClientOptions ClientOptions { get; private set; }

        public WebSocketClient WebSocketClient { get; private set; }

        public string Runtime => ConvertUnixTimeToTimeStamp(_runtime);

        private readonly long _runtime = Now();

        private static Bot _habibiTeaTime;


        public Bot()
        {
            ConnectionCredentials = new(Resources.Username, Resources.OAuth);
            ClientOptions = new()
            {
                ClientType = ClientType.Chat,
                ReconnectionPolicy = new(10000, 30000, 1000),
                UseSsl = true
            };
            WebSocketClient = new(ClientOptions);
            TwitchClient = new(WebSocketClient, ClientProtocol.WebSocket)
            {
                AutoReListenOnException = true
            };
            TwitchClient.Initialize(ConnectionCredentials, "xxdirkthecrafterxx");

            TwitchClient.OnLog += Client_OnLog;
            TwitchClient.OnConnected += Client_OnConnected;
            TwitchClient.OnJoinedChannel += Client_OnJoinedChannel;
            TwitchClient.OnMessageReceived += Client_OnMessageReceived;

            TwitchClient.Connect();
        }

        public void SetBot()
        {
            _habibiTeaTime = this;
        }

        public void Send(string channel, string message)
        {
            TwitchClient.SendMessage(channel, message);
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            MessageHandler.Handle(this, e.ChatMessage);

            Console.WriteLine($"#{e.ChatMessage.Channel}>{e.ChatMessage.Username}: {e.ChatMessage.Message}");
        }

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            Console.WriteLine("Joined " + e.Channel);
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            Console.WriteLine("Bot Connected.");
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {

        }
    }
}
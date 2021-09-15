using HabibiTeaTime.Twitch;
using HLE.Strings;
using System.Collections.Generic;
using System.Threading;

namespace HabibiTeaTime.Messages
{
    public class DividedMessage
    {
        public TwitchBot TwitchBot { get; }

        public string Channel { get; }

        public List<string> Messages { get; }

        public DividedMessage(TwitchBot twitchBot, string channel, string messages)
        {
            TwitchBot = twitchBot;
            Channel = channel;
            Messages = messages.Split(Config.MaxMessageLength);
        }

        public void StartSending()
        {
            TwitchBot.TwitchClient.SendMessage(Channel, $"{Messages[0]}");
            Messages.RemoveAt(0);
            if (Messages.Count > 0)
            {
                Thread.Sleep(Config.MinimumDelayBetweenMessages);
                Messages.ForEach(str =>
                {
                    TwitchBot.TwitchClient.SendMessage(Channel, str);
                    Thread.Sleep(Config.MinimumDelayBetweenMessages);
                });
            }
        }
    }
}

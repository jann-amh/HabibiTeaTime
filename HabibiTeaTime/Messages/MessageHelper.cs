using TwitchLib.Client.Models;

namespace HabibiTeaTime.Messages
{
    public static class MessageHelper
    {
        public static bool IsModOrBroadcaster(this ChatMessage chatMessage)
        {
            return chatMessage.IsModerator || chatMessage.IsBroadcaster;
        }
    }
}

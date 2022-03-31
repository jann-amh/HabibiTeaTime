using System.Collections.Generic;
using System.Text.Json;
using System.Web;
using HabibiTeaTime.HttpRequest.Enums;
using HabibiTeaTime.HttpRequest.Models;
using HabibiTeaTime.Utils;
using HLE.HttpRequests;

namespace HabibiTeaTime.HttpRequest
{
    public static class HttpRequest
    {
        public static string GetMathResult(string expression)
        {
            HttpGet request = new($"http://api.mathjs.org/v4/?expr={HttpUtility.UrlEncode(expression)}");
            return request.ValidJsonData ? request.Data.GetRawText() : request.Result;
        }


        public static List<Chatter> GetChatters(string channel)
        {
            HttpGet request = new($"https://tmi.twitch.tv/group/user/{channel.RemoveHashtag()}/chatters");
            JsonElement chatters = request.Data.GetProperty("chatters");
            List<Chatter> result = new();
            chatters.GetProperty("broadcaster").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Broadcaster)));
            chatters.GetProperty("vips").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Vip)));
            chatters.GetProperty("moderators").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Moderator)));
            chatters.GetProperty("staff").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Staff)));
            chatters.GetProperty("admins").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Admin)));
            chatters.GetProperty("global_mods").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.GlobalMod)));
            chatters.GetProperty("viewers").ToString().WordArrayStringToList().ForEach(c => result.Add(new(c, ChatRole.Viewer)));
            return result;
        }
    }
}

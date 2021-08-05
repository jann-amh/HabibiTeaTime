using HLE.HttpRequests;
using System.Web;

namespace HabibiTeaTime.HttpRequest
{
    public static class HttpRequest
    {
        public static string GetMathResult(string expression)
        {
            HttpGet request = new($"http://api.mathjs.org/v4/?expr={HttpUtility.UrlEncode(expression)}");
            return request.ValidJsonData ? request.Data.GetRawText() : request.Result;
        }
    }
}

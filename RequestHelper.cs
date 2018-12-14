using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace LaunchLibrary.NET
{
    public static class RequestHelper
    {
        private static readonly HttpClient client = new HttpClient();
        
        public static string GetRequest(string url)
        {
            var response = client.GetAsync(url).Result;

            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
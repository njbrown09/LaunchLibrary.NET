using System;
using System.Collections.Generic;
using LaunchLibrary.NET.JSON;
using Newtonsoft.Json;

namespace LaunchLibrary.NET
{
    public static class FetchData
    {
        public static List<Launch> GetNextLaunches(int count)
        {
            string data = RequestHelper.GetRequest($"https://launchlibrary.net/1.4/launch/next/{count}");

            var rootData = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            
            return JsonConvert.DeserializeObject<List<Launch>>(rootData["launches"].ToString());
        }
    }
}
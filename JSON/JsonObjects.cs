using System;
using System.Collections.Generic;

namespace LaunchLibrary.NET.JSON
{
    public class Agency
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abbrev { get; set; }
        public string countryCode { get; set; }
        public int type { get; set; }
        public object infoURL { get; set; }
        public string wikiURL { get; set; }
        public string changed { get; set; }
        public List<string> infoURLs { get; set; }
    }

    public class Pad
    {
        public int id { get; set; }
        public string name { get; set; }
        public string infoURL { get; set; }
        public string wikiURL { get; set; }
        public string mapURL { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public List<Agency> agencies { get; set; }
    }

    public class Location
    {
        public List<Pad> pads { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string infoURL { get; set; }
        public string wikiURL { get; set; }
        public string countryCode { get; set; }
    }

    public class Rocket
    {
        public int id { get; set; }
        public string name { get; set; }
        public string configuration { get; set; }
        public string familyname { get; set; }
        public List<Agency> agencies { get; set; }
        public string wikiURL { get; set; }
        public List<object> infoURLs { get; set; }
        public List<int> imageSizes { get; set; }
        public string imageURL { get; set; }
    }

    public class Payload
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Mission
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int type { get; set; }
        public string wikiURL { get; set; }
        public string typeName { get; set; }
        public List<Agency> agencies { get; set; }
        public List<Payload> payloads { get; set; }
    }

    public class LaunchServiceProvider
    {
        public int id { get; set; }
        public string name { get; set; }
        public string abbrev { get; set; }
        public string countryCode { get; set; }
        public int type { get; set; }
        public object infoURL { get; set; }
        public string wikiURL { get; set; }
        public string changed { get; set; }
        public List<string> infoURLs { get; set; }
    }

    public class Launch
    {

        public int id { get; set; }
        public string name { get; set; }
        public string windowstart { get; set; }
        public string windowend { get; set; }
        public string net { get; set; }
        public int wsstamp { get; set; }
        public int westamp { get; set; }
        public int netstamp { get; set; }
        public string isostart { get; set; }
        public string isoend { get; set; }
        public string isonet { get; set; }
        public int status { get; set; }
        public int inhold { get; set; }
        public int tbdtime { get; set; }
        public List<string> vidURLs { get; set; }
        public object vidURL { get; set; }
        public List<object> infoURLs { get; set; }
        public object infoURL { get; set; }
        public object holdreason { get; set; }
        public object failreason { get; set; }
        public string tbddate { get; set; }
        public double probability { get; set; }
        public string hashtag { get; set; }
        public string changed { get; set; }
        public Location location { get; set; }
        public Rocket rocket { get; set; }
        public List<Mission> missions { get; set; }
        public LaunchServiceProvider lsp { get; set; }
    }
}
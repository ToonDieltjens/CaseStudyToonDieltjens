using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyToonDieltjens.TvMazeApi
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Rating
    {
        public object average { get; set; }
    }

    public class Schedule
    {
        public string time { get; set; }
        public List<string> days { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }
        public string timezone { get; set; }
    }

    public class Network
    {
        public int id { get; set; }
        public string name { get; set; }
        public Country country { get; set; }
    }

    public class Externals
    {
        public object tvrage { get; set; }
        public object thetvdb { get; set; }
        public object imdb { get; set; }
    }

    public class Image
    {
        public string medium { get; set; }
        public string original { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Previousepisode
    {
        public string href { get; set; }
    }

    public class Nextepisode
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Previousepisode previousepisode { get; set; }
        public Nextepisode nextepisode { get; set; }
    }

    public class Show
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public List<object> genres { get; set; }
        public string status { get; set; }
        public int runtime { get; set; }
        public int averageRuntime { get; set; }
        public string premiered { get; set; }
        public object ended { get; set; }
        public string officialSite { get; set; }
        public Schedule schedule { get; set; }
        public Rating rating { get; set; }
        public int weight { get; set; }
        public Network network { get; set; }
        public object webChannel { get; set; }
        public object dvdCountry { get; set; }
        public Externals externals { get; set; }
        public Image image { get; set; }
        public object summary { get; set; }
        public int updated { get; set; }
        public Links _links { get; set; }
    }

    public class Root
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public int season { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public string airdate { get; set; }
        public string airtime { get; set; }
        public DateTime airstamp { get; set; }
        public int runtime { get; set; }
        public Rating rating { get; set; }
        public object image { get; set; }
        public object summary { get; set; }
        public Show show { get; set; }
        public Links _links { get; set; }
    }


}

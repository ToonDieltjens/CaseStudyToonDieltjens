using System;
using System.Collections.Generic;

namespace CaseStudyToonDieltjens
{
    class TvShow : Video
    {
        public String Airtime { get; private set; }
        public List<string> PlayDays { get; private set; }
        public string Channel { get; private set; }

        public TvShow(string name)
        {
            Name = name;
        }

        public TvShow(String airtime, List<string> playDays, string channel, string name)
        {
            Airtime = airtime;
            PlayDays = playDays;
            Channel = channel;
            Name = name;
        }

        public override string ToString()
        {
            return $"TV Show: {base.ToString()} Channel: {Channel} --- Airtime: {Airtime} --- Days on tv: {String.Join(", ", PlayDays)}";
        }
    }
}

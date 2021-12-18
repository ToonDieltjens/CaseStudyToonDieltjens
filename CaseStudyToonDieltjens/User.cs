using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyToonDieltjens
{
    static class User
    {
        public static List<Video> VideoList { get; set; }

        static User()
        {
            VideoList = new List<Video>();
        }

        public static void AddMovie(Movie movie)
        {
            //Movie Movie = new Movie(name, genre, director);
            VideoList.Add(movie);
        }

        public static void AddTvShow(TvShow tvShow)
        {
            //TvShow TvShow = new TvShow(airtime, playdays, channel, name, genre);
            VideoList.Add(tvShow);
        }
    }
}

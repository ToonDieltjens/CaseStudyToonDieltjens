using System.Collections.Generic;

namespace CaseStudyToonDieltjens
{
    static class User
    {
        public static List<Video> VideoList { get; private set; }

        static User()
        {
            VideoList = new List<Video>();
        }

        public static void AddMovie(Movie movie)
        {
            VideoList.Add(movie);
        }

        public static void AddTvShow(TvShow tvShow)
        {
            VideoList.Add(tvShow);
        }

        public static void RemoveVideo(Video video)
        {
            VideoList.Remove(video);
        }
    }
}

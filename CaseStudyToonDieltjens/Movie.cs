using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyToonDieltjens
{
    class Movie : Video
    {
        public string Director { get; set; }
        public string Genre { get; set; }

        public Movie(string name, string genre, string director)
        {
            Name = name;
            Genre = genre;
            Director = director;
        }

        public override string ToString()
        {
            return $"Movie: {base.ToString()} Genre: {Genre} --- Director: {Director}";
        }
    }
}

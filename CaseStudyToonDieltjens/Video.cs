using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyToonDieltjens
{
    class Video
    { 
        public string Name { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"{Name} --- Genre: {Genre} ---";
        }
    }
}

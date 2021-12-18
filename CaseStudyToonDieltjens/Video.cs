using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyToonDieltjens
{
    class Video
    { 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} --- ";
        }
    }
}

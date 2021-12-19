namespace CaseStudyToonDieltjens
{
    class Movie : Video
    {
        public string Director { get; private set; }
        public string Genre { get; private set; }

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

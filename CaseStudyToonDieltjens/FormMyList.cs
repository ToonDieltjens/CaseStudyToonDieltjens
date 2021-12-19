using System;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    public partial class FormMyList : Form
    {
        public FormMyList()
        {
            InitializeComponent();
            AddVideosToListBox();
        }

        // add all the videos that are in the VideoList to the listbox
        private void AddVideosToListBox()
        {
            foreach (Video video in User.VideoList)
            {
                if (video is Movie)
                {
                    var movie = (Movie)video;
                    listBox1.Items.Add(movie);
                    listBox1.Items.Add("");
                }
                if (video is TvShow)
                {
                    var tvShow = (TvShow)video;
                    listBox1.Items.Add(tvShow);
                    listBox1.Items.Add("");
                }
            }
        }

        // delete button clicked --> selected video will be removed from the VideoList and from the listbox
        private void button5_Click(object sender, EventArgs e)
        {
            var selectedVideo = listBox1.SelectedItem as Video;
            User.RemoveVideo(selectedVideo);

            if (listBox1.Items.Count > 0)
            {
                var index = listBox1.Items.IndexOf(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(++index);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formTvGuide = new FormTvGuide();
            Hide();
            formTvGuide.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formAddTvShow = new FormAddTvShow();
            Hide();
            formAddTvShow.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var formAddMovie = new FormAddMovie();
            Hide();
            formAddMovie.Show();
        }
    }
}

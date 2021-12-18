using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    public partial class FormMyList : Form
    {
        public FormMyList()
        {
            InitializeComponent();
            foreach (Video video in User.VideoList)
            {
                if(video is Movie)
                {
                    var movie = (Movie)video;
                    listBox1.Items.Add(movie);
                }
                if (video is TvShow)
                {
                    var tvShow = (TvShow)video;
                    listBox1.Items.Add(tvShow);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTvGuide formTvGuide = new FormTvGuide();
            Hide();
            formTvGuide.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAddTvShow formAddTvShow = new FormAddTvShow();
            Hide();
            formAddTvShow.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormAddMovie formAddMovie = new FormAddMovie();
            Hide();
            formAddMovie.Show();
        }

    }
}

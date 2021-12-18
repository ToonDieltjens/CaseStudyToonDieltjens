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
    public partial class FormAddTvShow : Form
    {
        public FormAddTvShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTvGuide formTvGuide = new FormTvGuide();
            Hide();
            formTvGuide.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAddMovie formAddMovie = new FormAddMovie();
            Hide();
            formAddMovie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMyList formMyList = new FormMyList();
            Hide();
            formMyList.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var genre = textBox2.Text;
            var channel = textBox3.Text;
            var airtime = textBox4.Text;
            var playDays = checkedListBox1.CheckedItems.OfType<string>().ToList();

            var tvShow = new TvShow(airtime, playDays, channel, name, genre);

            User.AddTvShow(tvShow);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    public partial class FormAddMovie : Form
    {
        public FormAddMovie()
        {
            InitializeComponent();
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
            var director = textBox3.Text;

            var movie = new Movie(name, genre, director);

            User.AddMovie(movie);
        }
    }
}

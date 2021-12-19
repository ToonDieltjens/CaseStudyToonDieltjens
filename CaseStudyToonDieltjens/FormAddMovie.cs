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

        // create new Movie from the user input
        private void button5_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var genre = textBox2.Text;
            var director = textBox3.Text;

            var movie = new Movie(name, genre, director);

            // add movie to VideoList
            User.AddMovie(movie);

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
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

        private void button4_Click(object sender, EventArgs e)
        {
            var formMyList = new FormMyList();
            Hide();
            formMyList.Show();
        }

    }
}

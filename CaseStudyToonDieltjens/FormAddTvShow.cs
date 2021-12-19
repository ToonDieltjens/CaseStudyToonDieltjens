using System;
using System.Linq;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    public partial class FormAddTvShow : Form
    {
        public FormAddTvShow()
        {
            InitializeComponent();
        }

        // create new TvShow from the user input
        private void button5_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var channel = textBox3.Text;
            var airtime = textBox4.Text;
            var playDays = checkedListBox1.CheckedItems.OfType<string>().ToList();

            var tvShow = new TvShow(airtime, playDays, channel, name);

            // add tvShow to VideoList
            User.AddTvShow(tvShow);

            // Clear all the input fields
            textBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;

            // Uncheck all the checkbox items
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formTvGuide = new FormTvGuide();
            Hide();
            formTvGuide.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formAddMovie = new FormAddMovie();
            Hide();
            formAddMovie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formMyList = new FormMyList();
            Hide();
            formMyList.Show();
        }

    }
}

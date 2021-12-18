using CaseStudyToonDieltjens.TvMazeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    public partial class FormTvGuide : Form
    {
        public FormTvGuide()
        {
            InitializeComponent();
            InitializeListView();
        }

        private async Task InitializeListView()
        {  
            var tvMazeApiService = new TvMazeApiService();
            var dateToday = DateTime.Now.ToString("yyyy-MM-dd");
            var showsToday = await tvMazeApiService.RetrieveTvShows(dateToday);
            foreach (var show in showsToday)
            {
                string[] stringShow = { show.Name, show.Channel, show.Airtime, String.Join(", ", show.PlayDays) };
                var listviewItem = new ListViewItem(stringShow);
                listView1.Items.Add(listviewItem);
            }
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
        private void button4_Click(object sender, EventArgs e)
        {
            FormMyList formMyList = new FormMyList();
            Hide();
            formMyList.Show();
        }
    }
}

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
            InitializeListView(listView1, true);
            InitializeListView(listView2, false);
        }

        private async Task InitializeListView(ListView listView, bool today)
        {  
            var tvMazeApiService = new TvMazeApiService();
            var date = "";
            if (today)
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                date = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            }
            
            var showsToday = await tvMazeApiService.RetrieveTvShows(date);
            foreach (var show in showsToday)
            {
                string[] stringShow = { show.Name, show.Channel, show.Airtime, String.Join(", ", show.PlayDays) };
                var listviewItem = new ListViewItem(stringShow);
                listView.Items.Add(listviewItem);
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

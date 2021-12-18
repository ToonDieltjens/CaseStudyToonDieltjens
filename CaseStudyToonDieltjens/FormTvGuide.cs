using CaseStudyToonDieltjens.TvMazeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        List<TvShow> allTvShows = new List<TvShow>();
        private async Task InitializeListView(ListView listView, bool today)
        {  
            var tvMazeApiService = new TvMazeApiService();
            string date;
            if (today)
            {
                date = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                date = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
            }
            
            var shows = await tvMazeApiService.RetrieveTvShows(date);
            
            foreach (var show in shows)
            {
                string[] stringShow = { show.Name, show.Channel, show.Airtime, String.Join(", ", show.PlayDays) };
                var listviewItem = new ListViewItem(stringShow);
                listView.Items.Add(listviewItem);

                allTvShows.Add(show);
            }
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
        private void button4_Click(object sender, EventArgs e)
        {
            var formMyList = new FormMyList();
            Hide();
            formMyList.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listView1.SelectedItems[0];

            foreach (var show in allTvShows)
            {
                Debug.WriteLine(selectedItem.Text);
                Debug.WriteLine(show.Name);
                if (selectedItem.Text.Equals(show.Name))
                {
                    User.AddTvShow(show);
                }
            }
        }
        
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = listView2.SelectedItems[0];
            
            foreach(var show in allTvShows)
            {
                Debug.WriteLine(selectedItem.Text);
                Debug.WriteLine(show.Name);
                if (selectedItem.Text.Equals(show.Name))
                {
                    User.AddTvShow(show);
                }
            }
        }
    }
}

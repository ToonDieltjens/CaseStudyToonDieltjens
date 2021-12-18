using CaseStudyToonDieltjens.TvMazeApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudyToonDieltjens
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            //var tvMazeApiService = new TvMazeApiService();
            //var date = DateTime.Now.ToString("yyyy-MM-dd");
            //var shows = await tvMazeApiService.RetrieveTvShows("date");
            //foreach (var show in shows)
            //{
            //    Debug.WriteLine(show.Name);
            //    Debug.WriteLine(show.Channel);
            //    Debug.WriteLine(String.Join(", ", show.PlayDays));
            //    Debug.WriteLine(show.Airtime);
            //}

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTvGuide());
        }
    }
}

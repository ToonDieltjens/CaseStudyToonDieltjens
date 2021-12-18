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
            var tvMazeApiService = new TvMazeApiService();
            var shows = await tvMazeApiService.RetrieveTvShows();
            foreach (var show in shows)
            {
                Debug.WriteLine(show.Name);
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTvGuide());
        }
    }
}

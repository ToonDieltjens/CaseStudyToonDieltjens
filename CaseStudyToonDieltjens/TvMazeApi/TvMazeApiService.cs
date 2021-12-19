using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CaseStudyToonDieltjens.TvMazeApi
{
    class TvMazeApiService
    {
        // get the TvShows from api (based on parameter date)
        // make an TvShow object of each TV show retrieved from the api
        // return the TvShow objects in a list
        public async Task<IList<TvShow>> RetrieveTvShows(string date)
        {
            var client = new HttpClient() { BaseAddress = new Uri("http://api.tvmaze.com/") };
            var response = await client.GetAsync("schedule?country=be&date=" + date);
            var json = await response.Content.ReadAsStringAsync();
            var roots = JsonSerializer.Deserialize<List<Root>>(json);

            return roots.Select(x => new TvShow(x.airtime, x.show.schedule.days, x.show.network.name, x.show.name)).ToList();
        }
    }
}

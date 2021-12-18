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
        public async Task<IList<TvShow>> RetrieveTvShows()
        {
            var client = new HttpClient() { BaseAddress = new Uri("http://api.tvmaze.com/") };
            var response = await client.GetAsync("schedule?country=be&date=2021-12-17");
            var json = await response.Content.ReadAsStringAsync();
            var roots = JsonSerializer.Deserialize<List<Root>>(json);

            return roots.Select(x => new TvShow(x.name.ToString())).ToList();

        }
    }
}

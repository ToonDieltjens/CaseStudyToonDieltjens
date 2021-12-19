using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaseStudyToonDieltjens.Interface
{
    // an interface is best practice when you want multiple implementations for unit tests
    interface ITvMazeApiService
    {
        Task<IList<TvShow>> RetrieveTvShows(string date);
    }
}

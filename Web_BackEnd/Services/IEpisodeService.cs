using Newtonsoft.Json;
using Web_BackEnd.Models;

namespace Web_BackEnd.Services
{
    public interface IEpisodeService
    {
        public Task<List<EpisodeViewModel>?> GetLatestThreeEpisodes(long id);
    }
}

using Newtonsoft.Json;
using Web_BackEnd.Models;

namespace Web_BackEnd.Services
{
    public class EpisodeService: IEpisodeService
    {
        private string BaseApiUrl => "http://api.sr.se/api/v2/episodes/index?format=json&size=3&sort=publishdateutc desc&";
        public async Task<List<EpisodeViewModel>?> GetLatestThreeEpisodes(long id)
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{BaseApiUrl}programid={id}");
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<EpisodeRootViewModel>(content);
            return data?.Episodes;
        }
    }
}

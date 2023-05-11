using Newtonsoft.Json;
using Web_BackEnd.Models;

namespace Web_BackEnd.Services
{
    public class ProgramService: IProgramService
    {
        private string BaseApiUrl => "https://api.sr.se/api/v2/programs/index?format=json&";



        public async Task<List<ProgramViewModel>?> GetPrograms()
        {
            var categoryId = 133;
            var url = $"{BaseApiUrl}programcategoryid={categoryId}&filter=program.haspod&filterValue=true&isarchived=false&size=50";
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ProgramsRootViewModel>(content);
            return data?.Programs;
        }

        public async Task<List<ProgramViewModel>?> GetHumorPrograms()
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{BaseApiUrl}programcategoryid=133");
            var content= await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ProgramsRootViewModel>(content);
            return data?.Programs;
        }

        public async Task<List<ProgramViewModel>?> GetHavePodcastsPrograms()
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{BaseApiUrl}filter=program.haspod&filterValue=true");
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ProgramsRootViewModel>(content);
            return data?.Programs;
        }

        public async Task<List<ProgramViewModel>?> GetNoArchivedPrograms()
        {
            using HttpClient client = new HttpClient();
            var response = await client.GetAsync($"{BaseApiUrl}isarchived=false");
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ProgramsRootViewModel>(content);
            return data?.Programs;
        }

    }
}

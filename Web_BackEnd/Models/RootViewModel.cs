using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class ProgramsRootViewModel
    {
        [JsonProperty("copyright")] public string? Copyright { get; set; }
        [JsonProperty("programs")] public List<ProgramViewModel>? Programs { get; set; }
        [JsonProperty("pagination")] public PaginationViewModel? Pagination { get; set; }
    }


    public class EpisodeRootViewModel
    {
        [JsonProperty("copyright")] public string? Copyright { get; set; }
        [JsonProperty("episodes")] public List<EpisodeViewModel>? Episodes { get; set; }
        [JsonProperty("pagination")] public PaginationViewModel? Pagination { get; set; }
    }
}

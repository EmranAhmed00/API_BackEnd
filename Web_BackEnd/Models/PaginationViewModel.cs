using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class PaginationViewModel
    {
        [JsonProperty("page")] public int Page { get; set; }
        [JsonProperty("size")] public int Size { get; set; }
        [JsonProperty("totalpages")] public int TotalPages { get; set; }
    }
}

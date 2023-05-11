using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class ReferenceViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }
    }
}

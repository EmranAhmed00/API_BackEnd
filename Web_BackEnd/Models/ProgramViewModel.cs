using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class ProgramViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("programimage")] public string? Image { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }
        [JsonProperty("channel")] public ReferenceViewModel? Channel { get; set; }
        [JsonIgnore] public string? ChannelName => Channel?.Name;
    }
}

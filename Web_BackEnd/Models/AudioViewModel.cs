using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class AudioViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("title")] public string? Title { get; set; }
        [JsonProperty("publishdateutc")] public DateTime? PublicationDateUtc { get; set; }
        [JsonProperty("duration")] public long? DurationValue { get; set; }
        [JsonProperty("url")] public string? AudioLink { get; set; }


        [JsonIgnore] public TimeSpan Duration => TimeSpan.FromSeconds(DurationValue ?? 0);
        [JsonIgnore] public DateTime? PublicationDate => PublicationDateUtc?.ToLocalTime();
    }
}

using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class BroadcastFileViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
      
        [JsonProperty("url")] public string? AudioLink { get; set; }

        [JsonProperty("duration")] public long? DurationValue { get; set; }
        [JsonIgnore] public TimeSpan Duration => TimeSpan.FromSeconds(DurationValue ?? 0);
    }
}

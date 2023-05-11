using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class PodcastViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("title")] public string? Title { get; set; }
        [JsonProperty("broadcastdateutc")] public DateTime? PublicationDateUtc { get; set; }

        [JsonIgnore] public DateTime? PublicationDate => PublicationDateUtc?.ToLocalTime();

        [JsonProperty("totalduration")] public long? DurationValue { get; set; }
        [JsonIgnore] public TimeSpan Duration => TimeSpan.FromSeconds(DurationValue??0);


        [JsonProperty("broadcastfiles")] public List<BroadcastFileViewModel>? Files { get; set; }
        [JsonIgnore] public string? DisplayAudioPlayer => Files.FirstOrDefault()?.AudioLink;
    }
}
using Newtonsoft.Json;

namespace Web_BackEnd.Models
{
    public class EpisodeViewModel
    {
        [JsonProperty("id")] public long? Id { get; set; }
        [JsonProperty("description")] public string? Description { get; set; }
        [JsonProperty("title")] public string? Title { get; set; }
        [JsonProperty("publishdateutc")] public DateTime? PublicationDateUtc { get; set; }

        [JsonIgnore] public DateTime? PublicationDate => PublicationDateUtc?.ToLocalTime();

        [JsonIgnore] public TimeSpan? Duration => ListenAudio?.Duration ?? DownloadAudio?.Duration ??
            Broadcast.Files?.FirstOrDefault()?.Duration;

        [JsonProperty("listenpodfile")] public AudioViewModel? ListenAudio { get; set; }
        [JsonProperty("downloadpodfile")] public AudioViewModel? DownloadAudio { get; set; }
        [JsonIgnore] public string? DisplayAudioPlayer => ListenAudio?.AudioLink ?? DownloadAudio?.AudioLink??
            Broadcast.Files?.FirstOrDefault()?.AudioLink;

        [JsonProperty("broadcast")] public PodcastViewModel Broadcast { get; set; }

    }
}
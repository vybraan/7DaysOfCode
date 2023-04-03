using System.Text.Json.Serialization;

public partial class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public Uri FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri FrontShiny { get; set; }
}

using System.Text.Json.Serialization;

public partial class Home
{
    [JsonPropertyName("front_default")]
    public Uri FrontDefault { get; set; }

    [JsonPropertyName("front_female")]
    public object FrontFemale { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_female")]
    public object FrontShinyFemale { get; set; }
}

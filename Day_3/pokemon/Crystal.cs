using System.Text.Json.Serialization;

public partial class Crystal
{
    [JsonPropertyName("back_default")]
    public Uri BackDefault { get; set; }

    [JsonPropertyName("back_shiny")]
    public Uri BackShiny { get; set; }

    [JsonPropertyName("back_shiny_transparent")]
    public Uri BackShinyTransparent { get; set; }

    [JsonPropertyName("back_transparent")]
    public Uri BackTransparent { get; set; }

    [JsonPropertyName("front_default")]
    public Uri FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri FrontShiny { get; set; }

    [JsonPropertyName("front_shiny_transparent")]
    public Uri FrontShinyTransparent { get; set; }

    [JsonPropertyName("front_transparent")]
    public Uri FrontTransparent { get; set; }
}

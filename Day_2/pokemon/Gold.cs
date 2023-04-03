using System.Text.Json.Serialization;

public partial class Gold
{
    [JsonPropertyName("back_default")]
    public Uri BackDefault { get; set; }

    [JsonPropertyName("back_shiny")]
    public Uri BackShiny { get; set; }

    [JsonPropertyName("front_default")]
    public Uri FrontDefault { get; set; }

    [JsonPropertyName("front_shiny")]
    public Uri FrontShiny { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("front_transparent")]
    public Uri FrontTransparent { get; set; }
}

using System.Text.Json.Serialization;

public partial class RedBlue
{
    [JsonPropertyName("back_default")]
    public Uri BackDefault { get; set; }

    [JsonPropertyName("back_gray")]
    public Uri BackGray { get; set; }

    [JsonPropertyName("back_transparent")]
    public Uri BackTransparent { get; set; }

    [JsonPropertyName("front_default")]
    public Uri FrontDefault { get; set; }

    [JsonPropertyName("front_gray")]
    public Uri FrontGray { get; set; }

    [JsonPropertyName("front_transparent")]
    public Uri FrontTransparent { get; set; }
}

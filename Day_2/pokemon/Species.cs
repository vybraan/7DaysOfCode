using System.Text.Json.Serialization;


public partial class Species
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public Uri Url { get; set; }
}
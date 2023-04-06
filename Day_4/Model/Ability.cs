namespace Models;

using System.Text.Json.Serialization;

public class Ability
{

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("url")]
    public string url { get; set; }

}

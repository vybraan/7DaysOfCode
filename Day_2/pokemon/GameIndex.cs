using System.Text.Json.Serialization;


public partial class GameIndex
{
    [JsonPropertyName("game_index")]
    public long GameIndexGameIndex { get; set; }

    [JsonPropertyName("version")]
    public Species Version { get; set; }
}

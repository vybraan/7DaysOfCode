using System.Text.Json.Serialization;



public partial class GenerationIi
{
    [JsonPropertyName("crystal")]
    public Crystal Crystal { get; set; }

    [JsonPropertyName("gold")]
    public Gold Gold { get; set; }

    [JsonPropertyName("silver")]
    public Gold Silver { get; set; }
}

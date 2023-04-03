using System.Text.Json.Serialization;


public partial class Versions
{
    [JsonPropertyName("generation-i")]
    public GenerationI GenerationI { get; set; }

    [JsonPropertyName("generation-ii")]
    public GenerationIi GenerationIi { get; set; }

    [JsonPropertyName("generation-iii")]
    public GenerationIii GenerationIii { get; set; }

    [JsonPropertyName("generation-iv")]
    public GenerationIv GenerationIv { get; set; }

    [JsonPropertyName("generation-v")]
    public GenerationV GenerationV { get; set; }

    [JsonPropertyName("generation-vi")]
    public Dictionary<string, Home> GenerationVi { get; set; }

    [JsonPropertyName("generation-vii")]
    public GenerationVii GenerationVii { get; set; }

    [JsonPropertyName("generation-viii")]
    public GenerationViii GenerationViii { get; set; }
}
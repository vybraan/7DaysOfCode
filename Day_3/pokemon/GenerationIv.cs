using System.Text.Json.Serialization;


public partial class GenerationIv
{
    [JsonPropertyName("diamond-pearl")]
    public Sprites DiamondPearl { get; set; }

    [JsonPropertyName("heartgold-soulsilver")]
    public Sprites HeartgoldSoulsilver { get; set; }

    [JsonPropertyName("platinum")]
    public Sprites Platinum { get; set; }
}

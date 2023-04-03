
using System.Text.Json.Serialization;

public partial class TypeElement
{
    [JsonPropertyName("slot")]
    public long Slot { get; set; }

    [JsonPropertyName("type")]
    public Species Type { get; set; }
}
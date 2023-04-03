using System.Text.Json.Serialization;


public partial class GenerationI
{
    [JsonPropertyName("red-blue")]
    public RedBlue RedBlue { get; set; }

    [JsonPropertyName("yellow")]
    public RedBlue Yellow { get; set; }
}

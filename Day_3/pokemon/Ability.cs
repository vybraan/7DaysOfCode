using System.Text.Json.Serialization;
public partial class Ability
{
    [JsonPropertyName("ability")]
    public Species AbilityAbility { get; set; }

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public long Slot { get; set; }

}
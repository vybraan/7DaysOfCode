namespace Models;

using System.Text.Json.Serialization;

public class Abilities
{

    [JsonPropertyName("ability")]
    private Ability ability { get; set; }

}

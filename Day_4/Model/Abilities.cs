namespace Models;

using System.Text.Json.Serialization;

public class Abilities
{

    [JsonPropertyName("ability")]
    public Ability ability { get; set; }

}

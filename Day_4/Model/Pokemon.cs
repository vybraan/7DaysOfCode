namespace Models;
using System.Text.Json.Serialization;

public class Pokemon
{

    [JsonPropertyName("abilities")]
    public List<Abilities> abilities { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("weight")]
    public double weight { get; set; }

    [JsonPropertyName("height")]
    public double height { get; set; }

    public override string ToString()
    {
        return "\n---------------------------------\n" +
          "Name: " + name + "\n" +
          "Height: " + height + "\n" +
          "Weight: " + weight + "\n" +
          "Habilidades: " + PrintAbilities(abilities);
    }


    public static string PrintAbilities(List<Abilities> abilities)
    {
        string abilities_names = "";

        foreach (var ability in abilities)
        {
            abilities_names += " " + ability.name;
        }

        return abilities_names;
    }

}

using RestSharp;
using System.Text.Json;
using System.Collections;

class Program{

  static void Main(string[] args){

    // string url = "https://pokeapi.co/api/v2/pokemon/";
    string url = "https://pokeapi.co/api/v2/pokemon/1/";

    var client = new RestClient(url); 

    var request = new RestRequest();

    var response = client.Get(request);



    Mascote mascote = JsonSerializer.Deserialize<Mascote>(response.Content);

    Console.WriteLine("Nome: "+ mascote.Name+"\n"
    +"Altura: "+mascote.Height+"\n"
    +"Peso: "+mascote.Weight+"\n"
    +"Habilidades: "+PrintAbilities(mascote.abilities));


  }

  public static string PrintAbilities(List<Ability> abilities){
    string abilities_names = "";

    foreach (var ability in abilities)
    {
      abilities_names += " "+ability.AbilityAbility.Name;
    }

    return abilities_names;
  }


}

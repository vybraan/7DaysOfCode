namespace Services;

using Models;
using RestSharp;
using System.Text.Json;
using System.Collections;

public class TamagotchiService
{
    private string url;
    private ArrayList pokemons = new ArrayList();
    private ArrayList pokemonNames = new ArrayList();
    private Random random = new Random(20);
    private RestRequest restRequest = new RestRequest();

    public TamagotchiService(string url)
    {
        this.url = url;
    }

    public ArrayList Tamagotchies()
    {
        if (pokemons != null)
        {
            int range = random.Next(10, 20);

            for (int i = 0; i < range; i++)
            {
                var client = new RestClient(url + (i + 1));

                var response = client.Get(restRequest);

                Pokemon pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);
                try
                {

                    this.pokemons.Add(pokemon);
                    this.pokemonNames.Add(pokemon.name);
                }
                catch (System.NullReferenceException e)
                {
                    Console.WriteLine("An exeception ocurred");
                    Console.WriteLine(e.ToString());
                }
            }
        }

        return this.pokemons;
    }

    public ArrayList TamagotchisNameList()
    {
        return pokemonNames;
    }





}

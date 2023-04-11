namespace Services;

using Models;
using RestSharp;
using System.Text.Json;

public class TamagotchiService
{
    private string url;
    private List<Pokemon> pokemons = new List<Pokemon>();

    private Random random = new Random(20);
    private RestRequest restRequest = new RestRequest();

    public TamagotchiService(string url)
    {
        this.url = url;
    }

    public List<Pokemon> Tamagotchies()
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
            }
            catch (System.NullReferenceException e)
            {
                Console.WriteLine("An exeception ocurred");
                Console.WriteLine(e.ToString());
            }
        }

        return this.pokemons;
    }


}

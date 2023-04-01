using RestSharp;


class Program{

  static void Main(string[] args){

    string url = "https://pokeapi.co/api/v2/pokemon/";

    var client = new RestClient(url); 

    var request = new RestRequest();

    var response = client.Get(request);

    Console.WriteLine(response.Content.ToString());
  }


}

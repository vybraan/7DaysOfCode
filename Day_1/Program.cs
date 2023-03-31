using RestSharp;


class Program{

  public static void Main(){
  using RestSharp;
using RestSharp.Authenticators;

var client = new RestClient("https://api.twitter.com/1.1") {
    Authenticator = new HttpBasicAuthenticator("username", "password")
};
var request = new RestRequest("statuses/home_timeline.json");
var response = await client.GetAsync(request, cancellationToken);
  }


//var request = new RestRequest("statuses/home_timeline.json");
//var response = await client.GetAsync(request, cancellationToken);
//
}

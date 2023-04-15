using Services;
using Controllers;
using Models;
using System.Timers;

// TamagotchiService tamagotchiService = new TamagotchiService("https://pokeapi.co/api/v2/pokemon/");

// List<Pokemon> pokemons = tamagotchiService.Tamagotchies();
// Console.WriteLine(pokemons);


TamagotchiController tamagotchiController = new TamagotchiController();

tamagotchiController.Jogar();

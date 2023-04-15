namespace Controllers;

using Views;
using Services;
using Models;
using System.Collections;

public class TamagotchiController
{
    TamagotchiView tamagotchiView;
    TamagotchiService tamagotchiService = new TamagotchiService("https://pokeapi.co/api/v2/pokemon/");
    ArrayList pokemons;
    public string username;
    public string[] pokemonsNames = new string[20];

    public ArrayList mascotesAdotados = new ArrayList();

    public TamagotchiController()
    {
        tamagotchiView = new TamagotchiView();
        pokemons = tamagotchiService.Tamagotchies();



    }

    public void Jogar()
    {
        tamagotchiView.Welcome();


        int optMenu = 0;
        do
        {
            tamagotchiView.MenuPrincipal();
            optMenu = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (optMenu)
            {
                case 1:
                    tamagotchiView.AdotarMascoteMenu(tamagotchiService.TamagotchisNameList());
                    int choosedM = int.Parse(Console.ReadLine()) - 1;
                    Console.Clear();

                    tamagotchiView.OpcoesAdotarMascoteMenu();
                    int opt = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine((Pokemon)pokemons[choosedM]);

                            break;

                        case 2:
                            mascotesAdotados.Add(pokemons[choosedM]);
                            Console.WriteLine("Mascote adotado com sucesso");

                            break;

                        default:
                            break;
                    }


                    break;

                case 2:
                    if (mascotesAdotados != null)
                    {
                        foreach (Pokemon pokemon in mascotesAdotados)
                        {
                            Console.WriteLine(pokemon);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ainda nao adoptaste nenhum mascote");
                    }

                    break;

                default:
                    break;
            }

        } while (optMenu != 3);


    }


}

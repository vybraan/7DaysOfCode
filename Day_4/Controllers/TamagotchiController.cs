namespace Controllers;

using Views;
using Services;
using Models;
using System.Collections;

public class TamagotchiController
{
    TamagotchiView tamagotchiView;
    TamagotchiService tamagotchiService = new TamagotchiService("https://pokeapi.co/api/v2/pokemon/");
    List<Pokemon> pokemons;
    public string username;
    public string[] pokemonsNames = new string[20];

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
            optMenu = Convert.ToInt32(Console.Read());

            switch (optMenu)
            {
                case 1:
                    tamagotchiView.AdotarMascoteMenu();
                    int choosedM = AdotarMascoteMenu(username);
                    int opt = OpcoesAdotarMascoteMenu(username);
                    switch (opt)
                    {
                        case 1:
                            Mascote mascote = mascotesDisponiveis[choosedM];
                            Console.WriteLine(PrintMascote(mascote));

                            break;

                        case 2:
                            mascotesAdotados.Add(mascotesDisponiveis[choosedM]);
                            Console.WriteLine("Mascote adotado com sucesso");

                            break;

                        default:
                            break;
                    }


                    break;

                case 2:
                    if (mascotesAdotados != null)
                    {
                        foreach (Mascote mascote in mascotesAdotados)
                        {
                            Console.WriteLine(PrintMascote(mascote));
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

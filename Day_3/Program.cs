using RestSharp;
using System;
using System.Text.Json;
using System.Collections;

class Program
{
    static Mascote[] mascotesDisponiveis;

    static List<Mascote> mascotesAdotados = new List<Mascote>();

    static void Main(string[] args)
    {
        mascotesDisponiveis = new Mascote[5];

        for (int i = 0; i < 5; i++)
        {
            string url = "https://pokeapi.co/api/v2/pokemon/";
            url = url + (i + 1) + "/";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.Get(request);
            Mascote mascote = JsonSerializer.Deserialize<Mascote>(response.Content);
            mascotesDisponiveis[i] = mascote;

        }

        Console.WriteLine(
    "\n                                                                            " +
    "\n████████╗ █████╗ ███╗   ███╗ █████╗  ██████╗  ██████╗ ████████╗ ██████╗██╗  ██╗██╗" +
    "\n╚══██╔══╝██╔══██╗████╗ ████║██╔══██╗██╔════╝ ██╔═══██╗╚══██╔══╝██╔════╝██║  ██║██║" +
    "\n   ██║   ███████║██╔████╔██║███████║██║  ███╗██║   ██║   ██║   ██║     ███████║██║" +
    "\n   ██║   ██╔══██║██║╚██╔╝██║██╔══██║██║   ██║██║   ██║   ██║   ██║     ██╔══██║██║" +
    "\n   ██║   ██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╔╝╚██████╔╝   ██║   ╚██████╗██║  ██║██║" +
    "\n   ╚═╝   ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝╚═╝  ╚═╝╚═╝" +
    "\n                                                                            ");
        Console.Write("What is your name: ");
        string username = Console.ReadLine();


        int optMenu = 0;
        do
        {
            optMenu = Menu(username);
            switch (optMenu)
            {
                case 1:
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

    public static int Menu(string username)
    {
        Console.WriteLine("\n -------------- MENU -------------- ");
        Console.WriteLine(username + " voce deseja?");
        Console.WriteLine("1. Adotar Mascotes Virtuais");
        Console.WriteLine("2. Ver seus mascotes");
        Console.WriteLine("3. Sair");
        Console.Write("OPCAO: ");
        return int.Parse(Console.ReadLine());
    }

    public static int AdotarMascoteMenu(string username)
    {
        Console.WriteLine("\n -------------- ADOTAR UM MASCOTE -------------- ");
        Console.WriteLine(username + " Escolha uma especie");
        for (int i = 0; i < mascotesDisponiveis.Length; i++)
        {
            Console.WriteLine(i + 1 + ". " + mascotesDisponiveis[i].Name);

        }
        Console.Write("OPCAO: ");
        return int.Parse(Console.ReadLine());
    }

    public static int OpcoesAdotarMascoteMenu(string username)
    {
        Console.WriteLine(" \n--------------------------------- ");
        Console.WriteLine(username + " voce deseja?");
        Console.WriteLine("1. Sabar Mais Sobre o Mascote");
        Console.WriteLine("2. Adotar Mascote");
        Console.WriteLine("3. Voltar");
        Console.Write("OPCAO: ");
        return int.Parse(Console.ReadLine());
    }



    public static string PrintMascote(Mascote mascote)
    {
        return "\n---------------------------------\nNome: " + mascote.Name + "\n"
                                         + "Altura: " + mascote.Height + "\n"
                                         + "Peso: " + mascote.Weight + "\n"
                                         + "Habilidades: " + PrintAbilities(mascote.abilities);
    }

    public static string PrintAbilities(List<Ability> abilities)
    {
        string abilities_names = "";

        foreach (var ability in abilities)
        {
            abilities_names += " " + ability.AbilityAbility.Name;
        }

        return abilities_names;
    }



}

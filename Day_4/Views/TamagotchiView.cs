namespace Views;

using System.Collections;

public class TamagotchiView
{
    public string username;

    public TamagotchiView()
    {

    }

    public void Welcome()
    {
        Console.WriteLine(@"                                                                            
████████╗ █████╗ ███╗   ███╗ █████╗  ██████╗  ██████╗ ████████╗ ██████╗██╗  ██╗██╗
╚══██╔══╝██╔══██╗████╗ ████║██╔══██╗██╔════╝ ██╔═══██╗╚══██╔══╝██╔════╝██║  ██║██║
   ██║   ███████║██╔████╔██║███████║██║  ███╗██║   ██║   ██║   ██║     ███████║██║
   ██║   ██╔══██║██║╚██╔╝██║██╔══██║██║   ██║██║   ██║   ██║   ██║     ██╔══██║██║
   ██║   ██║  ██║██║ ╚═╝ ██║██║  ██║╚██████╔╝╚██████╔╝   ██║   ╚██████╗██║  ██║██║
   ╚═╝   ╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝    ╚═╝    ╚═════╝╚═╝  ╚═╝╚═╝
");
        Console.Write("What is your name: ");
        this.username = Console.ReadLine();

    }

    public void MenuPrincipal()
    {
        Console.WriteLine("\n -------------- MENU -------------- ");
        Console.WriteLine($"Ola,  {username} voce deseja?");
        Console.WriteLine("1. Adotar Mascotes Virtuais");
        Console.WriteLine("2. Ver seus mascotes");
        Console.WriteLine("3. Sair");
        Console.Write("OPCAO: ");
    }

    public void AdotarMascoteMenu(ArrayList pokemonList)
    {
        Console.WriteLine("\n -------------- ADOTAR UM MASCOTE -------------- ");
        Console.WriteLine($" Escolha uma especie {username}");
        int i = 1;

        foreach (var pokemon in pokemonList)
        {
            Console.WriteLine($"{i}. {pokemon}");
            i++;
        }
        Console.Write("OPCAO: ");
    }

    public void OpcoesAdotarMascoteMenu()
    {
        Console.WriteLine(" \n--------------------------------- ");
        Console.WriteLine($"{username}, voce deseja?");
        Console.WriteLine("1. Sabar Mais Sobre o Mascote");
        Console.WriteLine("2. Adotar Mascote");
        Console.WriteLine("3. Voltar");
        Console.Write("OPCAO: ");
    }


}

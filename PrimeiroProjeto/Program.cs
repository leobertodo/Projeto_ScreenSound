using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }

    static string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    static List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

    static void ExibirLogo()
    {
        Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        ");
        Console.WriteLine(mensagemDeBoasVindas);
    }
    static void ExibirOpcoesDoMenu() //Mova a função para dentro da classe
    {
        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("Digite a sua opcao: ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


        switch (opcaoEscolhidaNumerica)
        {
            case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 2: Console.WriteLine("Você escolheu a opção " +  opcaoEscolhidaNumerica);
                break;
            case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            case -1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                break;
            default: Console.WriteLine("Opção falsa");
                break;
        }
    }
}
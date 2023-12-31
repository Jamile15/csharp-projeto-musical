﻿//Screen Sound

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

string mensagemDeBoasVindas = "Não to pronta pra essa semana";

void ExibirLogo()
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
//uma lista de coisas
//List<string> listaDasBandas = new List<string>{ "Mamonas", "Nx0"};

//dicionario da pra criar uma lista e atribuir valores como nome de banda e notas
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("mamonas", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("nx0", new List<int>());

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigirte 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir uma media de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.Write("\n digite a sua opção:");

    ///pegar o valor que for digitado 
    string opcaoEscolhida = Console.ReadLine()!;
    //convertendo a string da opção escolhida pra um valor inteiro 
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // ao invez de ficar usando varios if else uso o switch passao o parametro e uso o case pra tipo "caso o 1 seja digitado retorne 
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasregistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opção invalida");
            break;

    }
    Console.WriteLine("tchau tchau :)");
}

void ExibitTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBandas()
{
    Console.Clear();
    ExibitTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    //concatenação de string diferente das outras linguas
    Console.WriteLine($"a A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void MostrarBandasregistradas()


{
    Console.Clear();
    ExibitTituloDaOpcao("Exibindo bandas cadastradas");
    //percorrendo lista de forma verbosa

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda {listaDasBandas[i]}");
    // }
    //////////////////////////////////////////////////////////////////////////////////
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");

    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    //capturando o que o user digitou 
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //verificar se a banda existe no dicionario 
    //SearchOption existir atribuir uma nota
    // se não pode voltar pro menu principal
    Console.Clear();
    ExibitTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota que a banda {nomeDaBanda} merece");
        int nota = int.Parse(Console.ReadLine()!);
        //atribuindo nota pra banda
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\n A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("digite uma tecla para voltar ao menu principal");
        //qualquer tecla readkey
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirMedia()
{
    Console.Clear();
    ExibitTituloDaOpcao("Exibir media banda");
    Console.WriteLine("\nDigite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey (nomeDaBanda))
    {
        List<int> notasDabanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDabanda.Average ()}");
        Console.WriteLine("Digite uma media para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($" A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();


    }
}

ExibirOpcoesDoMenu();

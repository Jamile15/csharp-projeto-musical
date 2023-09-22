//Screen Sound

using System.ComponentModel.Design;
using System.Runtime.InteropServices;

string mensagemDeBoasVindas = "Não to pronta pra essa semana";

void ExibirLogo()
{
    Console.WriteLine(@"
█▀█ █░█ █▀▀ █▀█ █▀█   █▀▄▀█ █ █▄░█ █░█ ▄▀█   █▀▀ ▄▀█ █▀▄▀█ ▄▀█
▀▀█ █▄█ ██▄ █▀▄ █▄█   █░▀░█ █ █░▀█ █▀█ █▀█   █▄▄ █▀█ █░▀░█ █▀█
");
    Console.WriteLine(mensagemDeBoasVindas);
}

List<string> listaDasBandas = new List<string>();

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
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
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

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("Registro de banda");
    Console.WriteLine("************************************************");
    Console.Write("Digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    //concatenação de string diferente das outras linguas
    Console.WriteLine($"a A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void MostrarBandasregistradas()
{
    Console.Clear();
    Console.WriteLine("************************************************");
    Console.WriteLine("Lista de bandas");
    Console.WriteLine("************************************************");
    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda {listaDasBandas[i]}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu");
    //capturando o que o user digitou 
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirOpcoesDoMenu();

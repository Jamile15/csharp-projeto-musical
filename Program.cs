//Screen Sound

string mensagemDeBoasVindas ="Não to pronta pra essa semana";


void ExibirMensagemDeBoasVindas(){
    Console.WriteLine(@"
█▀█ █░█ █▀▀ █▀█ █▀█   █▀▄▀█ █ █▄░█ █░█ ▄▀█   █▀▀ ▄▀█ █▀▄▀█ ▄▀█
▀▀█ █▄█ ██▄ █▀▄ █▄█   █░▀░█ █ █░▀█ █▀█ █▀█   █▄▄ █▀█ █░▀░█ █▀█
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigirte 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("digite 3 para avaliar uma banda");
    Console.WriteLine("digite 4 para exibir uma media de uma banda");
    Console.WriteLine("digite -1 para sair");

    Console.Write("\n digite a sua opção:");

    ///pegar o valor que for digitado 
     string opcaoEscolhida =  Console.ReadLine()!;
     //convertendo a string da opção escolhida pra um valor inteiro 
     int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
     if (opcaoEscolhidaNumerica == 1)
     {
        Console.WriteLine("Você digitou a a opção " + opcaoEscolhida);
     } else if (opcaoEscolhidaNumerica == 2)
     {
        Console.WriteLine("Você digitou a a opção " + opcaoEscolhida);
     };
 
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

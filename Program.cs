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


};

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();

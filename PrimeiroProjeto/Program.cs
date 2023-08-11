//Screen Sound
string mensagemBoasVindas = "Boas Vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};

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

    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesDoMenu ()
{
    ExibirLogo();
    //\n pra dar espaço
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite a opção desejada:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


    /*
     * 
    if(opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    } else if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }

    */

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau Tchau :)");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("***********************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("***********************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("Exibindo todas as Bandas Registradas");
    Console.WriteLine("**************************************\n");
    /* 
     * for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu() ;
    
}


ExibirOpcoesDoMenu();

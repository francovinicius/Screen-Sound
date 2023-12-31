﻿//Screen Sound
string mensagemBoasVindas = "Boas Vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};

//criando um dicionario vazio
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Linkin Park", new List<int> ());

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
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMediaDaBanda();
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
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindos todas as bandas registradas");
    /* 
     * for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPrecione qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
    
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    //escrever * a esquerda // quando é um caracter usamos aspas simples ''
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    //digitar a banda desejada
    //verificar se a banda existe
    //atribuir nota

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda"); 
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    // usa-se o ! pq não queremos um valor nulo
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        //passando a nota de string para int
        int nota = int.Parse(Console.ReadLine()!);
        //add nota a lista
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("\nNota registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear() ;
        ExibirOpcoesDoMenu();

    } else 
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        //qualquer tecla
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da Banda");
    Console.Write("Digite o nome da banda: ");
    //pegar nome da banda
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é:  {notasDaBanda.Average()}!");

        Console.WriteLine("\nPrecione qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        //qualquer tecla
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();

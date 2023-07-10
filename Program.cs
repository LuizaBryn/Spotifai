
//Curso Csharp - Criando um APP de Músicas//

List<string> bandasRegistradas = new List<string> {"Os Bergamotas", "Mustaches", "Marshmallow Lazer"};

void ExibirCabecalho()
{ 
Console.WriteLine(@"
░██████╗██████╗░░█████╗░████████╗██╗███████╗░█████╗░██╗
██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██║
╚█████╗░██████╔╝██║░░██║░░░██║░░░██║█████╗░░███████║██║
░╚═══██╗██╔═══╝░██║░░██║░░░██║░░░██║██╔══╝░░██╔══██║██║
██████╔╝██║░░░░░╚█████╔╝░░░██║░░░██║██║░░░░░██║░░██║██║
╚═════╝░╚═╝░░░░░░╚════╝░░░░╚═╝░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚═╝
        ");
        Console.WriteLine("Boas vindas ao Spotifai, seu App de músicas mutcho loco");
        Console.WriteLine("=======================================================");
}

void ExibirMenu()
{
    ExibirCabecalho();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma avaliação");
    Console.WriteLine("Digite 0 para sair");

    //Ao usar apenas White, a string não vai ocupar a linha inteira do log//

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //A "!" Serve para não ser depositado cum valor nulo
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MostrarMedia();
            break;
        case 0: Console.WriteLine("Você escolheu sair");
            break;
        default: Console.WriteLine("Selecione uma opção válida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("==== Registro de bandas ====");
    Console.Write("Qual banda você deseja registrar? ");
    string registroBanda = Console.ReadLine()!;
    bandasRegistradas.Add(registroBanda);
    Console.WriteLine($"Você registrou {registroBanda} com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("======= Bandas no Spotifai ========\n");
    for (int i = 0; i < bandasRegistradas.Count; i++)
    {
        Console.WriteLine($" + {bandasRegistradas[i]}");
    }
    Console.WriteLine("\n===================================");
    Console.WriteLine("\nClique qualquer botão para retornar");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void AvaliarBanda()
{
    Console.Clear();

    Console.WriteLine("SALVE");

    Console.Clear();
    ExibirMenu();
}

void MostrarMedia()
{ 
    Console.Clear();

    Console.WriteLine("SALVE");

    Console.Clear();
    ExibirMenu();

}

ExibirMenu();

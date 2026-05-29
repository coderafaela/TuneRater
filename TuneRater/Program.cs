string mensagemDeBoasVindas = "Bem-vinde ao TuneRater!";
Dictionary<string, List<double>> bandasRegistradas = new Dictionary<string, List<double>>();
Dictionary<string, List<double>> registroDeCantores = new Dictionary<string, List<double>>();


void ExibirLogo()
{
    Console.WriteLine(@"


████████╗██╗░░░██╗███╗░░██╗███████╗██████╗░░█████╗░████████╗███████╗██████╗░
╚══██╔══╝██║░░░██║████╗░██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
░░░██║░░░██║░░░██║██╔██╗██║█████╗░░██████╔╝███████║░░░██║░░░█████╗░░██████╔╝
░░░██║░░░██║░░░██║██║╚████║██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██╔══╝░░██╔══██╗
░░░██║░░░╚██████╔╝██║░╚███║███████╗██║░░██║██║░░██║░░░██║░░░███████╗██║░░██║
░░░╚═╝░░░░╚═════╝░╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝");

    Console.WriteLine(@"

█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
");
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para exibir todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir uma média de uma banda");
    Console.WriteLine("Digite 5 para registrar um cantor(a)");
    Console.WriteLine("Digite 6 para exibir todos cantores");
    Console.WriteLine("Digite 7 para avaliar um(a) cantor(a)");
    Console.WriteLine("Digite 8 para exibir a média de um cantor");
    Console.WriteLine("Digite 9 para exibir todas as bandas e cantores");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MediaBanda();
            break;
        case 5:
            RegistrarCantores();
            break;
        case 6:
            MostrarCantores();
            break;
        case 7:
            AvaliarCantor();
            break;
        case 8:
            MediaCantor();
            break;
        case 9:
            MostrarBandasECantores();
            break;
        case -1:
            Console.WriteLine("Bye bye, bitch");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.WriteLine(" ");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<double>());
    Console.WriteLine("A banda {0} foi registrada com sucesso!", nomeDaBanda);
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();


}

void RegistrarCantores()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ██▄ ▄█");
    Console.WriteLine(" ");
    Console.Write("Digite o nome do(a) cantor(a) que deseja registrar: ");
    string nomeDeCantor = Console.ReadLine()!;
    registroDeCantores.Add(nomeDeCantor, new List<double>());
    Console.WriteLine("{0} foi registrade com sucesso!", nomeDeCantor);
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();


}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.WriteLine(" ");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();


}
void MostrarCantores()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ██▄ ▄█");
    Console.WriteLine(" ");
    foreach (string cantor in registroDeCantores.Keys)
    {
        Console.WriteLine(cantor);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();


}
void MostrarBandasECantores()
{
    Console.Clear();
    Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.WriteLine(" ");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine(" ");
    Console.WriteLine(@"
█▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ██▄ ▄█");
    Console.WriteLine(" ");
    foreach (string banda in registroDeCantores.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();

}

void AvaliarUmaBanda()
{
    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ █▀▀   █░█ █▀▄▀█ ▄▀█   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█
█▀█ ▀▄▀ █▀█ █▄▄ █ ██▄   █▄█ █░▀░█ █▀█   █▄█ █▀█ █░▀█ █▄▀ █▀█");
    Console.WriteLine(" ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Digite a nota que deseja dar para a banda {nomeBanda}: ");
        double notaBanda = double.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(notaBanda);
        Console.WriteLine($"\nA nota {notaBanda} foi registrada com sucesso para a banda {nomeBanda}!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine($"\nOps, a banda {nomeBanda} não foi encontrada. Verifique se digitou o nome corretamente.");
        Console.WriteLine("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
   
}

void AvaliarCantor()
{
    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ █▀▀   █░█ █▀▄▀█ ▄▀ ▄▀█ ▀▄   █▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ ▄▀ ▄▀█ ▀▄
█▀█ ▀▄▀ █▀█ █▄▄ █ ██▄   █▄█ █░▀░█ ▀▄ █▀█ ▄▀   █▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ▀▄ █▀█ ▄▀");
    Console.WriteLine(" ");
    Console.Write("Digite o nome de qual cantor que deseja avaliar: ");
    string nomeCantor = Console.ReadLine()!;
    if (registroDeCantores.ContainsKey(nomeCantor))
    {
        Console.Write($"Digite a nota que deseja dar para o(a) cantor(a) {nomeCantor}: ");
        double notaCantor = double.Parse(Console.ReadLine()!);
        registroDeCantores[nomeCantor].Add(notaCantor);
        Console.WriteLine($"\nA nota {notaCantor} foi registrada com sucesso para o(a) cantor(a) {nomeCantor}!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine($"\nOps, o(a) cantor(a) {nomeCantor} não foi encontrado(a). Verifique se digitou o nome corretamente.");
        Console.WriteLine("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
}

void MediaBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▄ █▀▀ █▀ █▀▀ █░█ █▄▄ █▀█ ▄▀█   ▄▀█   █▀▄▀█ █▀▀ █▀▄ █ ▄▀█   █▀▄ ▄▀█   █▀ █░█ ▄▀█   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█
█▄▀ ██▄ ▄█ █▄▄ █▄█ █▄█ █▀▄ █▀█   █▀█   █░▀░█ ██▄ █▄▀ █ █▀█   █▄▀ █▀█   ▄█ █▄█ █▀█   █▄█ █▀█ █░▀█ █▄▀ █▀█

█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀▄ ▄▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▄▀ █▀█");
    Console.WriteLine(" ");
    Console.Write("Digite o nome da banda que deseja ver nota média em avaliações feitas: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
      List<double> notasDaBanda = bandasRegistradas[nomeBanda];
      Console.WriteLine($"\nA média de avaliações da banda {nomeBanda} é: {notasDaBanda.Average()}");
      Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
      Console.ReadKey();
      Console.Clear();
      ExibirLogo();
      ExibirOpcoesDoMenu();
    } else {
      Console.WriteLine($"\nOps, a banda {nomeBanda} não foi encontrada. Verifique se digitou o nome corretamente.");
      Console.WriteLine("Digite uma tecla para voltar ao menu: ");
      Console.ReadKey();
      Console.Clear();
      ExibirLogo();
      ExibirOpcoesDoMenu();
    }
}

void MediaCantor()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▄ █▀▀ █▀ █▀▀ █░█ █▄▄ █▀█ ▄▀█   ▄▀█   █▀▄▀█ █▀▀ █▀▄ █ ▄▀█   █▀▄ █▀▀   █░█ █▀▄▀█ ▄▀ ▄▀█ ▀▄
█▄▀ ██▄ ▄█ █▄▄ █▄█ █▄█ █▀▄ █▀█   █▀█   █░▀░█ ██▄ █▄▀ █ █▀█   █▄▀ ██▄   █▄█ █░▀░█ ▀▄ █▀█ ▄▀

█▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ ▄▀ ▄▀█ ▀▄   █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀▄ █▀█ ▄▀ ▄▀█ ▀▄
█▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ▀▄ █▀█ ▄▀   █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▄▀ █▄█ ▀▄ █▀█ ▄▀");
    Console.WriteLine(" ");
    Console.Write("Digite o nome do(a) cantor(a) que deseja ver nota média em avaliações feitas: ");
    string nomeCantor = Console.ReadLine()!;
    if (registroDeCantores.ContainsKey(nomeCantor))
    {
        List<double> notasDeCantores = registroDeCantores[nomeCantor];
        Console.WriteLine($"\nA média de avaliações do(a) cantor(a) {nomeCantor} é: {notasDeCantores.Average()}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine($"\nOps,o nome do(a) cantor(a) {nomeCantor} não foi encontrado. Verifique se digitou o nome corretamente.");
        Console.WriteLine("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirLogo();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();

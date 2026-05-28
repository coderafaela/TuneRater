string mensagemDeBoasVindas = "Bem-vinde ao TuneRater";
List<string> listaDeBandas = new List<string>();
List<string> listaDeCantores = new List<string>();


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
    Console.WriteLine("Digite 4 para registrar um cantor(a)");
    Console.WriteLine("Digite 5 para exibir todos cantores");
    Console.WriteLine("Digite 6 para avaliar um(a) cantor(a)");
    Console.WriteLine("Digite 7 para exibir a média de uma banda");
    Console.WriteLine("Digite 8 para exibir todas as bandas e cantores");
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
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 4:
            RegistrarCantores();
            break;
        case 5:
            MostrarCantores();
            break;
        case 6:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 7:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 8:
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
    listaDeBandas.Add(nomeDaBanda);
    Console.WriteLine("A banda {0} foi registrada com sucesso!", nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
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
    listaDeCantores.Add(nomeDeCantor);
    Console.WriteLine("{0} foi registrade com sucesso!", nomeDeCantor);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.WriteLine(" ");
    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}
void MostrarCantores()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ██▄ ▄█");
    Console.WriteLine(" ");
    for (int i = 0; i < listaDeCantores.Count; i++)
    {
        Console.WriteLine(listaDeCantores[i]);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();


}
void MostrarBandasECantores()
{
    Console.Clear();
    Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.WriteLine(" ");
    foreach (string banda in listaDeBandas)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine(" ");
    Console.WriteLine(@"
█▀▀ ▄▀█ █▄░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▄▄ █▀█ █░▀█ ░█░ █▄█ █▀▄ ██▄ ▄█");
    Console.WriteLine(" ");
    for (int i = 0; i < listaDeCantores.Count; i++)
    {
        Console.WriteLine(listaDeCantores[i]);
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}


ExibirOpcoesDoMenu();

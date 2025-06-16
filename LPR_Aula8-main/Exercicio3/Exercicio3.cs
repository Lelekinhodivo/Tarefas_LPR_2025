using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static Heroi[] equipe = new Heroi[3];
    static int totalCadastrados = 0;
    static int totalSelecionados = 0;

    static void Main()
    {
        menuPrincipal();
    }

    static void cadastrarHeroi()
    {
        if (totalCadastrados >= 5)
        {
            Console.WriteLine("Limite de heróis cadastrados atingido!\n");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[totalCadastrados].Nome = Console.ReadLine();

        Console.Write("Poder do herói: ");
        herois[totalCadastrados].Poder = Console.ReadLine();

        Console.Write("Pontuação do herói: ");
        herois[totalCadastrados].Pontuacao = int.Parse(Console.ReadLine());

        totalCadastrados++;
        Console.WriteLine("Herói cadastrado com sucesso!\n");
    }

    static void selecionarEquipe()
    {
        if (totalCadastrados < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis antes de montar a equipe.\n");
            return;
        }

        totalSelecionados = 0;

        Console.WriteLine("Heróis disponíveis:");
        for (int i = 0; i < totalCadastrados; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].Nome} ({herois[i].Poder}) - Pontuação: {herois[i].Pontuacao}");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nSelecione o número do {i + 1}º herói: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < totalCadastrados)
            {
                equipe[i] = herois[indice];
                totalSelecionados++;
            }
            else
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                i--;
            }
        }

        Console.WriteLine("\nEquipe selecionada com sucesso!\n");
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;
        for (int i = 0; i < totalSelecionados; i++)
        {
            total += equipe[i].Pontuacao;
        }
        return total;
    }

    static void exibirEquipe()
    {
        if (totalSelecionados < 3)
        {
            Console.WriteLine("Equipe ainda não foi selecionada.\n");
            return;
        }

        Console.WriteLine("Heróis da equipe:");
        for (int i = 0; i < totalSelecionados; i++)
        {
            Console.WriteLine($"- {equipe[i].Nome} ({equipe[i].Poder}) - Pontuação: {equipe[i].Pontuacao}");
        }

        Console.WriteLine($"Pontuação total da equipe: {calcularPontuacaoTotal()}\n");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Cadastrar Herói");
            Console.WriteLine("2. Selecionar Equipe");
            Console.WriteLine("3. Exibir Equipe");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;
                case 2:
                    selecionarEquipe();
                    break;
                case 3:
                    exibirEquipe();
                    break;
                case 4:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.\n");
                    break;
            }

        } while (opcao != 4);
    }
}

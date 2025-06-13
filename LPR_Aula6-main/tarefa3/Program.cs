//Exercício 3) Desenvolva um programa em C# que simule um sistema de seleção de heróis da Marvel para uma equipe. O programa deve
//ter as seguintes funcionalidades: a) Cadastro de Heróis: Crie uma função chamada cadastrarHeroi que permita ao usuário
//inserir o nome, poder e pontuação de um herói da Marvel. A função deve solicitar essas informações ao usuário e armazená-las 
//em variáveis. Não é necessário armazenar os heróis em uma lista ou vetor. O programa deve permitir o cadastro de até 5 heróis.
//b) Seleção de Equipe: Crie uma função chamada selecionarEquipe que permita ao usuário selecionar heróis para formar sua equipe.
//A função deve exibir os heróis cadastrados e permitir que o usuário selecione quais heróis deseja incluir em sua equipe. 
//O usuário deve ser capaz de selecionar três heróis para sua equipe. c) Pontuação Total da Equipe:Crie uma função chamada 
//calcularPontuacaoTotal que calcule a pontuação total da equipe com base nos heróis selecionados. A pontuação total da equipe 
//deve ser a soma das pontuações individuais de cada herói selecionado. d) Exibição da Equipe: Crie uma função chamada exibirEquipe 
//que exiba os heróis selecionados para a equipe, seu poder e a pontuação total da equipe. e) Menu: Crie uma função chamada 
//menuPrincipal que exiba um menu com as opções disponíveis para o usuário (cadastro de heróis, seleção de equipe, exibição da equipe
//e sair do programa). O usuário deve poder escolher uma das opções do menu e o programa deve executar a funcionalidade correspondente.
//Requisitos Adicionais: O programa deve continuar em execução até que o usuário escolha a opção de sair.
//Utilize variáveis locais para armazenar as informações dos heróis e da equipe. Não utilize classes, vetores ou listas! 

using System;
class Program
{
     static void cadastrarHeroi(ref string h1Nome, ref string h1Poder, ref int h1Pont,
     ref string h2Nome, ref string h2Poder, ref int h2Pont,
     ref string h3Nome, ref string h3Poder, ref int h3Pont,
     ref string h4Nome, ref string h4Poder, ref int h4Pont,
     ref string h5Nome, ref string h5Poder, ref int h5Pont)
    {
     Console.WriteLine("Cadastro de até 5 heróis da Marvel:");
     Console.Write("Nome do Herói 1: ");
     h1Nome = Console.ReadLine();
     Console.Write("Poder do Herói 1: ");
     h1Poder = Console.ReadLine();
     Console.Write("Pontuação do Herói 1: ");
     h1Pont = int.Parse(Console.ReadLine());

     Console.Write("Nome do Herói 2: ");
     h2Nome = Console.ReadLine();
     Console.Write("Poder do Herói 2: ");
     h2Poder = Console.ReadLine();
     Console.Write("Pontuação do Herói 2: ");
     h2Pont = int.Parse(Console.ReadLine());

     Console.Write("Nome do Herói 3: ");
     h3Nome = Console.ReadLine();
     Console.Write("Poder do Herói 3: ");
     h3Poder = Console.ReadLine();
     Console.Write("Pontuação do Herói 3: ");
     h3Pont = int.Parse(Console.ReadLine());

     Console.Write("Nome do Herói 4: ");
     h4Nome = Console.ReadLine();
     Console.Write("Poder do Herói 4: ");
     h4Poder = Console.ReadLine();
     Console.Write("Pontuação do Herói 4: ");
     h4Pont = int.Parse(Console.ReadLine());

     Console.Write("Nome do Herói 5: ");
     h5Nome = Console.ReadLine();
     Console.Write("Poder do Herói 5: ");
     h5Poder = Console.ReadLine();
     Console.Write("Pontuação do Herói 5: ");
     h5Pont = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe(out int e1, out int e2, out int e3)
    {
     Console.WriteLine("Selecione 3 heróis para sua equipe (escolha números de 1 a 5):");
     Console.Write("Herói 1: ");
     e1 = int.Parse(Console.ReadLine());
     Console.Write("Herói 2: ");
     e2 = int.Parse(Console.ReadLine());
     Console.Write("Herói 3: ");
     e3 = int.Parse(Console.ReadLine());
    }

    static int calcularPontuacaoTotal(int e1, int e2, int e3,
                                      int p1, int p2, int p3, int p4, int p5)
    {
     int total = 0;

     if (e1 == 1) total += p1;
     else if (e1 == 2) total += p2;
     else if (e1 == 3) total += p3;
     else if (e1 == 4) total += p4;
     else if (e1 == 5) total += p5;

     if (e2 == 1) total += p1;
     else if (e2 == 2) total += p2;
     else if (e2 == 3) total += p3;
     else if (e2 == 4) total += p4;
     else if (e2 == 5) total += p5;

     if (e3 == 1) total += p1;
     else if (e3 == 2) total += p2;
     else if (e3 == 3) total += p3;
     else if (e3 == 4) total += p4;
     else if (e3 == 5) total += p5;

     return total;
    }

    static void exibirEquipe(int e1, int e2, int e3,
     string n1, string n2, string n3, string n4, string n5,
     string poder1, string poder2, string poder3, string poder4, string poder5,
     int p1, int p2, int p3, int p4, int p5)
    {
     Console.WriteLine("\nEquipe Selecionada:");
     int total = 0;

        void mostrar(int e)
        {
         if (e == 1) { Console.WriteLine($"{n1} - Poder: {poder1} - Pontuação: {p1}"); total += p1; }
         else if (e == 2) { Console.WriteLine($"{n2} - Poder: {poder2} - Pontuação: {p2}"); total += p2; }
         else if (e == 3) { Console.WriteLine($"{n3} - Poder: {poder3} - Pontuação: {p3}"); total += p3; }
         else if (e == 4) { Console.WriteLine($"{n4} - Poder: {poder4} - Pontuação: {p4}"); total += p4; }
         else if (e == 5) { Console.WriteLine($"{n5} - Poder: {poder5} - Pontuação: {p5}"); total += p5; }
        }

        mostrar(e1);
        mostrar(e2);
        mostrar(e3);

        Console.WriteLine($"Pontuação total da equipe: {total}");
    }

    static void menuPrincipal()
    {
     string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";
     string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
     int pont1 = 0, pont2 = 0, pont3 = 0, pont4 = 0, pont5 = 0;
     int escolha, eq1 = 0, eq2 = 0, eq3 = 0;

        do
        {
         Console.WriteLine("\n===== MENU PRINCIPAL =====");
         Console.WriteLine("1 - Cadastrar Heróis");
         Console.WriteLine("2 - Selecionar Equipe");
         Console.WriteLine("3 - Exibir Equipe");
         Console.WriteLine("0 - Sair");
         Console.Write("Escolha uma opção: ");
         escolha = int.Parse(Console.ReadLine());

         switch (escolha)
         {
          case 1:
          cadastrarHeroi(ref nome1, ref poder1, ref pont1,
          ref nome2, ref poder2, ref pont2,
          ref nome3, ref poder3, ref pont3,
          ref nome4, ref poder4, ref pont4,
          ref nome5, ref poder5, ref pont5);
          break;

          case 2:
          Console.WriteLine("\nHeróis disponíveis:");
          Console.WriteLine("1 - " + nome1);
          Console.WriteLine("2 - " + nome2);
          Console.WriteLine("3 - " + nome3);
          Console.WriteLine("4 - " + nome4);
          Console.WriteLine("5 - " + nome5);
          selecionarEquipe(out eq1, out eq2, out eq3);
          break;

          case 3:
          exibirEquipe(eq1, eq2, eq3,
          nome1, nome2, nome3, nome4, nome5,
          poder1, poder2, poder3, poder4, poder5,
          pont1, pont2, pont3, pont4, pont5);
          break;

          case 0:
          Console.WriteLine("Saindo do programa...");
          break;

          default:
          Console.WriteLine("Opção inválida!");
          break;
            }

        } while (escolha != 0);
    }

    static void Main(string[] args)
    {
     menuPrincipal();
    }
}

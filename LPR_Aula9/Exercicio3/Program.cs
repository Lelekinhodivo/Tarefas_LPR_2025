using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        for (int i = 0; i < quantidade; i++)
        {
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            pessoas[nome] = idade;
        }

        double media = pessoas.Values.Average();

        foreach (var pessoa in pessoas)
            if (pessoa.Value > media)
                Console.WriteLine(pessoa.Key);

        var maisVelho = pessoas.Aggregate((x, y) => x.Value > y.Value ? x : y);
        var maisNovo = pessoas.Aggregate((x, y) => x.Value < y.Value ? x : y);

        Console.WriteLine("Mais velho: " + maisVelho.Key);
        Console.WriteLine("Mais novo: " + maisNovo.Key);

        int idadeParaRemover = int.Parse(Console.ReadLine());

        var chavesParaRemover = pessoas.Where(p => p.Value == idadeParaRemover)
                                       .Select(p => p.Key)
                                       .ToList();

        foreach (var chave in chavesParaRemover)
            pessoas.Remove(chave);

        foreach (var pessoa in pessoas)
            Console.WriteLine(pessoa.Key + ": " + pessoa.Value);
    }
}

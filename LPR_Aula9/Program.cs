using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int quantidade = int.Parse(Console.ReadLine());
        List<string> nomes = new List<string>();

        for (int i = 0; i < quantidade; i++)
        {
            nomes.Add(Console.ReadLine());
        }

        List<string> nomesRestantes = new List<string>(nomes);

        while (nomesRestantes.Count > 0)
        {
            HashSet<int> tamanhosUsados = new HashSet<int>();
            List<string> linha = new List<string>();

            foreach (var nome in nomes)
            {
                if (nomesRestantes.Contains(nome) && !tamanhosUsados.Contains(nome.Length))
                {
                    linha.Add(nome);
                    tamanhosUsados.Add(nome.Length);
                    nomesRestantes.Remove(nome);
                }
            }

            linha.Sort((a, b) => a.Length.CompareTo(b.Length));
            Console.WriteLine(string.Join(" ", linha));
        }
    }
}

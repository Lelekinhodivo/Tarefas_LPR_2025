using System;  

class Program
{
    static void Main()
    {
       
        string[] cidades = { "Vitória", "Belo Horizonte", "Rio de Janeiro", "São Paulo" };

        int[,] distancias = {
            { 0, 524, 521, 882 },
            { 524, 0, 434, 586 },
            { 521, 434, 0, 429 },
            { 882, 586, 429, 0 }
        };

        Console.WriteLine("Distância entre as cidades (km):");
        Console.Write("\t"); 
        for (int i = 0; i < cidades.Length; i++)
            Console.Write(cidades[i] + "\t"); 
        Console.WriteLine();

        for (int i = 0; i < cidades.Length; i++)
        {
            Console.Write(cidades[i] + "\t");  
            for (int j = 0; j < cidades.Length; j++)
                Console.Write(distancias[i, j] + "\t");  
            Console.WriteLine();
        }

        
        Console.WriteLine("\nDigite o nome das cidades para saber a distância entre elas.");
        Console.WriteLine("Digite o mesmo nome para origem e destino para sair.");

        
        while (true)
        {
            Console.Write("\nCidade origem: ");
            string origem = Console.ReadLine().Trim();  // lê a cidade origem e remove espaços extras

            Console.Write("Cidade destino: ");
            string destino = Console.ReadLine().Trim(); // lê a cidade destino e remove espaços extras

            // Se a origem for igual ao destino (ignorando maiúsculas/minúsculas), encerra o programa
            if (string.Equals(origem, destino, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Origem e destino são iguais. Programa encerrado.");
                break;  
            }

            // Busca o índice da cidade origem no array cidades, ignorando maiúsculas/minúsculas
            int idxOrigem = Array.FindIndex(cidades, c => c.Equals(origem, StringComparison.OrdinalIgnoreCase));
            // Busca o índice da cidade destino
            int idxDestino = Array.FindIndex(cidades, c => c.Equals(destino, StringComparison.OrdinalIgnoreCase));

            // Se a cidade origem não foi encontrada, mostra erro e continua para a próxima interação do loop
            if (idxOrigem == -1)
            {
                Console.WriteLine($"Cidade origem '{origem}' não encontrada. Tente novamente.");
                continue;  
            }
            // Se a cidade destino não foi encontrada, mostra erro e continua
            if (idxDestino == -1)
            {
                Console.WriteLine($"Cidade destino '{destino}' não encontrada. Tente novamente.");
                continue;
            }

            // Se as duas cidades foram encontradas, pega a distância na matriz pelo índice
            int distancia = distancias[idxOrigem, idxDestino];
            // Imprime a distância encontrada para o usuário
            Console.WriteLine($"Distância entre {cidades[idxOrigem]} e {cidades[idxDestino]}: {distancia} km");
        }
    }
}

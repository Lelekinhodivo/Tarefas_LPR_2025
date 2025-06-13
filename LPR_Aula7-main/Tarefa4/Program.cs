using System;

class Program
{
    static void Main()
    {
        int[,] A = new int[3, 3];
        int[,] B = new int[3, 3];
        int[,] C = new int[3, 3]; // Resultado da multiplicação A * B

        Console.WriteLine("Digite os valores da matriz A (3x3):");
        LerMatriz(A);

        Console.WriteLine("Digite os valores da matriz B (3x3):");
        LerMatriz(B);

        // Multiplicação de matrizes
        for (int i = 0; i < 3; i++) // linha da matriz A
        {
            for (int j = 0; j < 3; j++) // coluna da matriz B
            {
                C[i, j] = 0;
                for (int k = 0; k < 3; k++) // coluna de A e linha de B
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\nResultado da multiplicação A * B:");
        ImprimirMatriz(C);
    }

    static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(matriz[i, j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }
    }
}

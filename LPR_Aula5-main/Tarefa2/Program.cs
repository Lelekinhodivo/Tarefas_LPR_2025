using System;
class Program
{
static void Main()
{
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1, 101);
int tentativa, tentativas = 0;
do
{
Console.Write("Digite um número entre 1 e 100: ");
tentativa = int.Parse(Console.ReadLine());
tentativas++;
if (tentativa > valorInteiro)
Console.WriteLine("Chutou alto!");
else if (tentativa < valorInteiro)
Console.WriteLine("Chutou baixo!");
else
Console.WriteLine($"Acertou! Número de tentativas: {tentativas}");
} while (tentativa != valorInteiro);
}
}

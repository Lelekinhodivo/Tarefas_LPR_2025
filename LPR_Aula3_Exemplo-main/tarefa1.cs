using System;
class Program
{
static void Main()
{
Console.Write("Digite um numero inteiro: ");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
Console.WriteLine("Par");
else
Console.WriteLine("Impar");
}
}
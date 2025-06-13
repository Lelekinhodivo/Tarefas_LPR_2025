using System;
class Program
{
static void Main()
{
Console.Write("Digite a quantidade de números: ");
int quantidade = int.Parse(Console.ReadLine());
int soma = 0, contagem = 0, i = 0;
while (i < quantidade)
{
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
soma += numero;
contagem++;
}
i++;
}
double media = contagem > 0 ? (double)soma / contagem : 0;
Console.WriteLine("Média dos números pares: " + media);
}
}

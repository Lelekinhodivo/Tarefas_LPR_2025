using System;
class Program
{
static void Main()
{
Console.WriteLine("Escolha uma classe de personagem:");
Console.WriteLine("1 - Guerreiro");
Console.WriteLine("2 - Mago");
Console.WriteLine("3 - Arqueiro");
Console.Write("Digite o numero da classe: ");
int escolha = int.Parse(Console.ReadLine());
switch (escolha)
{
case 1:
Console.WriteLine("Guerreiro: Corte Devastador, Defesa de Ferro");
break;
case 2:
Console.WriteLine("Mago: Bola de Fogo, Escudo Arcano");
break;
case 3:
Console.WriteLine("Arqueiro: Flecha Veloz, Disparo Multiplo");
break;
default:
Console.WriteLine("Classe invalida!");
break;
}
}
}
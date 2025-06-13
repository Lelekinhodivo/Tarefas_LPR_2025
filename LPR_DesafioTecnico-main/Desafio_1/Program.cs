//Crie pelo menos duas variáveis de cada tipo primitivo de dado (inteiro, número de ponto flutuante,
//booleano e caracter) para armazenar informações básicas do personagem e de uma rede social que
//ele possa ter.
//a. Para os números de ponto flutuante, crie pelo menos uma variável do tipo float e outra do
//tipo double.
//b. Além de variáveis de tipo primitivo, crie duas strings para armazenar informações textuais.
//c. Você pode criar mais de 10 variáveis. Entretanto, 10 é o limite mínimo!
//2. Utilize no mínimo dois comandos de entrada de dados para solicitar informações relevantes sobre o
//personagem ao usuário.
//3. Utilize comandos de saída para apresentar as informações do personagem de forma organizada e
//amigável ao usuário.
//personagem: jake (hora de aventura)

using System;

class Program
{
    static void Main()
    {
        string nome = "Jake, o Cao";
        string universo = "Hora de Aventura";
        int idade = 28;
        int filhos = 5;
        float altura = 1.20f;
        double peso = 35.5;
        char inicial = 'J';
        bool temPoderes = true;
        
        
        Console.Write("Digite a melhor habilidade do Jake: ");
        string habilidade = Console.ReadLine();
        
        Console.Write("Digite a comida favorita do Jake: ");
        string comidaFavorita = Console.ReadLine();
        
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Universo: " + universo);
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("Filhos: " + filhos);
        Console.WriteLine("Altura: " + altura + " metros");
        Console.WriteLine("Peso: " + peso + " kg");
        Console.WriteLine("Inicial do Nome: " + inicial);
        Console.WriteLine("Possui poderes? " + (temPoderes ? "Sim" : "Nao"));
        Console.WriteLine("Melhor Habilidade: " + habilidade);
        Console.WriteLine("Comida Favorita: " + comidaFavorita);
       
    }
}
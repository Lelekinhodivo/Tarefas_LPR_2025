using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Matrícula: ");
            a.Matricula = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();

            Console.Write("Nota da primeira prova: ");
            a.Nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota da segunda prova: ");
            a.Nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota do trabalho: ");
            a.NotaTrabalho = double.Parse(Console.ReadLine());

            Console.WriteLine();
            a.MostrarDados();
        }
    }
}

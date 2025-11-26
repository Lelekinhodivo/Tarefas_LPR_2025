using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            f.MostrarDados();

            Console.Write("Porcentagem de aumento: ");
            double p = double.Parse(Console.ReadLine());
            f.AumentarSalario(p);

            Console.WriteLine("Dados atualizados:");
            f.MostrarDados();
        }
    }
}

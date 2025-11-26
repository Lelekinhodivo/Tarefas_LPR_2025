using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Digite a largura: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área = " + r.CalcArea());
            Console.WriteLine("Perímetro = " + r.CalcPerimetro());
        }
    }
}

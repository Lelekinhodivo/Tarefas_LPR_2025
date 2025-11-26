using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Aluno
    {
        public int Matricula;
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double NotaTrabalho;

        public double Media()
        {
            return (Nota1 * 2.5 + Nota2 * 2.5 + NotaTrabalho * 2) / 7;
        }

        public double Final()
        {
            double media = Media();
            if (media >= 6)
                return 0;
            else
                return 6 - media;
        }

        public void MostrarDados()
        {
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Média: " + Media().ToString("F2"));
            Console.WriteLine("Precisa na final: " + Final().ToString("F2"));
        }
    }
}

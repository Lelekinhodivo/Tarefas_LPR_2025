using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;

        public double CalcularImposto()
        {
            if (SalarioBruto <= 2000)
                return SalarioBruto * 0.10;
            else if (SalarioBruto <= 3000)
                return SalarioBruto * 0.15;
            else
                return SalarioBruto * 0.20;
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - CalcularImposto();
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Salário líquido: " + SalarioLiquido());
        }
    }
}

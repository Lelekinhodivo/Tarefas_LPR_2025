using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double CalcArea()
        {
            return Altura * Largura;
        }

        public double CalcPerimetro()
        {
            return 2 * (Altura + Largura);
        }
    }
}

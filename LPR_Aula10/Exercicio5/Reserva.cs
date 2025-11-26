using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Reserva
    {
        public DateTime Data;
        public Cliente Cliente;

        public Reserva(DateTime data, Cliente cliente)
        {
            Data = data;
            Cliente = cliente;
        }
    }
}

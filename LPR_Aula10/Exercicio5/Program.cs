using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Nome = "Alex";

            Reserva r1 = new Reserva(new DateTime(2025, 11, 20), c1);
            Reserva r2 = new Reserva(new DateTime(2025, 12, 5), c1);
            Reserva r3 = new Reserva(new DateTime(2025, 10, 10), c1);

            c1.AdicionarReserva(r1);
            c1.AdicionarReserva(r2);
            c1.AdicionarReserva(r3);

            c1.ListarReservasFuturas();
        }
    }
}

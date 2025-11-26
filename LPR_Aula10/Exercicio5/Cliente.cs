using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Cliente
    {
        public string Nome;
        public List<Reserva> Reservas = new List<Reserva>();

        public void AdicionarReserva(Reserva r)
        {
            Reservas.Add(r);
        }

        public void ListarReservasFuturas()
        {
            Console.WriteLine("Reservas futuras de " + Nome + ":");
            foreach (var r in Reservas)
            {
                if (r.Data > DateTime.Now)
                {
                    Console.WriteLine("Reserva em " + r.Data.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}

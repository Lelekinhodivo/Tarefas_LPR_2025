using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = ano;
        }

        public void MostrarDados()
        {
            Console.WriteLine(Titulo + " - " + Autor + " (" + AnoPublicacao + ")");
        }
    }
}

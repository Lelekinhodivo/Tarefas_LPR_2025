using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            Console.WriteLine("Livros na biblioteca:");
            foreach (var livro in livros)
            {
                livro.MostrarDados();
            }
        }
    }
}

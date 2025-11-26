using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca();

            Livro l1 = new Livro("Dom Casmurro", "Machado de Assis", 1899);
            Livro l2 = new Livro("O Hobbit", "J.R.R. Tolkien", 1937);
            Livro l3 = new Livro("1984", "George Orwell", 1949);

            b.AdicionarLivro(l1);
            b.AdicionarLivro(l2);
            b.AdicionarLivro(l3);

            b.ListarLivros();
        }
    }
}

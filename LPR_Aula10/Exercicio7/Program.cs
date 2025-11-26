using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ana");
            Aluno a2 = new Aluno("Bruno");

            Turma t1 = new Turma("Matemática");
            Turma t2 = new Turma("História");

            a1.AdicionarMatricula(t1);
            a1.AdicionarMatricula(t2);
            a1.AdicionarMatricula(t1); 

            a2.AdicionarMatricula(t1);

            t1.ListarAlunos();
            t2.ListarAlunos();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Aluno
    {
        public string nome;
        public int idade;
        public double notaFinal;

        public void MostrarNota()
        {
            Console.WriteLine($"O Aluno {nome}, tem {idade} anos ficou com a nota final {notaFinal}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Livro
    {
        public string titulo;
        public string autor;
        public string paginas;

        public void MostrarInformacoes()
        {
            Console.WriteLine($"O livro cadastrado, tem o autor: {autor}, titulo: {titulo} e quantidade de paginas: {paginas}");
        }
    }
}

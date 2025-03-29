using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Funcionarios
{
    class Gerente : Funcionario
    {
        public void Bonificar()
        {
            Console.WriteLine(_salario = _salario * 1.15);
        }
    }
}

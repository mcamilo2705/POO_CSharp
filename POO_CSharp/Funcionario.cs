using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Funcionario
    {
        //criando atributos
        private double _salario = 0;

        public void SetSalario(double valor)
        {
            _salario = valor;
        }
        public double GetSalario()
        {
           return _salario; 
        }
    }
}

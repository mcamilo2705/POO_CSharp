using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Contas
{
    class ContaPoupanca : ContaBancaria
    {
        private double juros = 0.05 ;

        public void RenderJuros()
        {
            Console.WriteLine(_saldo = _saldo + (_saldo * juros)); 
        }

    }
}


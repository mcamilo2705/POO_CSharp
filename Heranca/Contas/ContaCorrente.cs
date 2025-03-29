using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Contas
{
    class ContaCorrente : ContaBancaria
    {
        private double taxa = 10;
        public void CobrarTaxa()
        {
            Console.WriteLine(_saldo = _saldo - taxa); 
        }
    }
}

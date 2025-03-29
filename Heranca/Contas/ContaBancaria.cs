using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Contas
{
    class ContaBancaria
    {
        //criando atributos
        protected double _saldo = 0;

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public void Sacar(double valor)
        {

            if (_saldo < valor)
            {
                Console.WriteLine("Saldo insulficiente");
            }
            else
            {
                _saldo -= valor;
            }
        }

        //public void VerSaldo()
        //{
        //    Console.WriteLine("O saldo e: " + _saldo); ;
        //}

        public double VerSaldo()
        {
            return _saldo;
        }

    }
}

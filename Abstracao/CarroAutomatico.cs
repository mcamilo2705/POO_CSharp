using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class CarroAutomatico : ICarro
    {
        public void TrocarMarcha()
        {
            Console.WriteLine("Carro automatico, trocando a marchar");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    //Contrato, aqui informa o que o carro tem que ter
    interface ICarro
    {
        void TrocarMarcha(); //diferente dos metodos, na interface nao e informado o que o metodo faz
    }
}

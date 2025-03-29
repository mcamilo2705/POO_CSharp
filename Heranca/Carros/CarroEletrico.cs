using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Carros
{
    class CarroEletrico : Carro
    {
        public int bateria;
        public int tempoDeCarga;

        //Ao chamar o metodo que esta na classe Carro, para sobrescrever deve usar a palabra override, em linhas gerais o override esta limpando o metodo e estamos definindo os atributos.
        public override void MostrarInformacoes()
        {
            //Para nao ter a necessidade de informar todos os atributos, tem a opcao de usar a palavra base, usando ela, automaticamente ja vai carregar tudo do metodo.
            base.MostrarInformacoes();
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
            Console.WriteLine("Bateria: " + bateria);
            Console.WriteLine("Tempo de Carga: " + tempoDeCarga);

        }
    }
}

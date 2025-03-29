using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Carros
{
    class Carro
    {
        public string modelo;
        public string marca;
        public int quilometragem;
    

    //Metodo criado para exemplo de polimorfismo, a palavra virtual significa que esse metodo pode ser sobrescrito, esse metodo esta sendo usando no projeto Polimorfismo
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
        }

        //Tipo de polimorfismo, um metodo com o mesmo nome pode depetir porem um com parametro e outro sem parametro
        public void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
            Console.WriteLine("Nome: " + nome);

        }
    }
}

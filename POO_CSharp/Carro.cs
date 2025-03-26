using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Carro
    {
        //criando atributos
        public string marca;
        public string modelo;
        public int anoFrabricacao;

        //criando metodos
        public void Andar()
        {
            Console.WriteLine("O carro esta em movimento");
        }

        public void Parar()
        {
            Console.WriteLine("O carro esta parando");
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de fabricacao: {anoFrabricacao}");
        }

    }
}

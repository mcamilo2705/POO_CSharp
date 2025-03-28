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
        private string _modelo;
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
            Console.WriteLine($"Marca: {marca}, Modelo: {_modelo}, Ano de fabricacao: {anoFrabricacao}");
        }

        //Medotos Get e Set com encapsulamento
         public void SetModelo(string mod)
        {
            if(mod == "Fiesta" || mod == "HB20")
            {
                _modelo = mod;
            }
            else
            {
                Console.WriteLine("Alteracao invalida");
            }
        }

        public string GetModelo() 
        { 
            return _modelo;
        }

    }
}

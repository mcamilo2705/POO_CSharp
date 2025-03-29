using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CSharp
{
    class Retangulo
    {
        private double _largura = 0;
        private double _altura = 0;

        public void SetLargura(double valor)
        {
            _largura = valor;
        }
        public void SetAltura(double valor)
        {
            _altura = valor;
        }
        public double GetLargura()
        {
            return _largura;
        }
        public double GetAltura()
        {
            return _altura;
        }

        public double CalcularArea()
        {
           double calc = _largura * _altura;
            return calc;
        }
    }
}

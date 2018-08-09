using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo12
{
    class Retangulo
    {
        public double largura;
        public double altura;


        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return 2.0 * (largura + altura);
        }

        public double diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }


    }
}

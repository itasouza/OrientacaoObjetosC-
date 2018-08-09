using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo10
{
    class Triangulo
    {
       public double a, b, c;


        public double area()
        {
           double p = (a + b + c) / 2.0;
           return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

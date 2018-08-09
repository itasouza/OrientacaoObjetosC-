using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 Fazer um programa para ler os valores da largura e altura
de um retângulo. Em seguida, mostrar na tela o valor de
sua área, perímetro e diagonal. Usar uma classe como
mostrado no projeto ao lado.
Entrada: Saída:
3.00
4.00
AREA = 12.00
PERIMETRO = 14.00
DIAGONAL = 5.00
     */

namespace Exemplo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + x.area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + x.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + x.diagonal().ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}

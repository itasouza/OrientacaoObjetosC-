using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Problema exemplo
Fazer umprogramaparaler as medidasdoslados dedoistriângulos Xe Y
(suponha medidasválidas). Em seguida, mostraro valor das áreas dos dois
triângulosedizerqualdosdoistriângulospossuiamaiorárea.
Afórmulaparacalcularaáreadeumtriânguloapartirdasmedidasdeseuslados
a,becéaseguinte(fórmuladeHeron):
     
    Entrada:
Aentradaconsistedovalordasmedidas‘a’, ‘b’ e‘c’ dotriângulo X,seguidadas
medidas‘a’,‘b’e‘c’ dotriânguloY,todosvalorescomduascasasdecimais.
Saída:
AsaídacontémasáreasdostriângulosXeYconformeexemplo(comquatrocasas
decimais),seguidadainformação dequaltriângulopossuiamaiorárea,conforme
exemplo(seasáreasforemiguais,mostreamensagem“AREASIGUAIS”).

    Entrada
    3.00
4.00
5.00
7.50
4.50
4.02
Saida
AREA DOTRIANGULO X: 6.0000
AREA DOTRIANGULO Y: 7.5638
TRIANGULO DE MAIOR AREA: Y

     */

namespace Exemplo10
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();
            
            double areaX, areaY;

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.area();
            areaY = Y.area();


            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else
            {
                Console.WriteLine("AREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}

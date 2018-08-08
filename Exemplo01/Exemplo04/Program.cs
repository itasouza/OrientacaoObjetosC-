using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir. Você deve criar 
um programa para, dadas as medidas das três tentativas de lançamento, informar qual foi a maior.
Entrada
A entrada contém os valores das medidas em metros das três distâncias às quais o dardo foi arremessado, com duas casas 
decimais.
Saída
A saída contém a maior das distâncias, com duas casas decimais.
Exemplos:
Entrada  Saída
83.21 87.20 79.53  87.20
Entrada  Saída
87.20 87.20 79.53  87.20
Entrada  Saída
83.21 87.20 83.21  87.20
SOLUÇÃO:
     */
namespace Exemplo04
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            string[] vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);
            if (x > y && x > z)
            {
                Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (y > z)
            {
                Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2) Deseja-se fazer um programa para calcular a nota final de um estudante, considerando as três notas que ele tirou nos 
três trimestres de seu curso. Caso a nota final do estudante seja menor que 60.00, deve-se mostrar uma mensagem 
"DEPENDENCIA" também.
Entrada:
A entrada possui as três notas do estudante, com duas casas decimais.
Saída:
A saída possui a nota final do estudante com duas casas decimais. Caso a nota seja menor que 60.00, a saída também 
possui a mensagem "DEPENDENCIA".
Exemplos:
Entrada  Saída
22.00 30.10 25.50  77.60
Entrada  Saída
15.00 20.00 20.00  55.00
DEPENDENCIA
SOLUÇÃO:
     
     */

namespace Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, soma;
            string[] vet = Console.ReadLine().Split(' ');
            N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            soma = N1 + N2 + N3;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            if (soma < 60.0)
            {
                Console.WriteLine("DEPENDENCIA");
            }
            Console.ReadLine();

        }
    }
}

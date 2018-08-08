using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 4) Fazer um programa para ler a quantidade de glicose no sangue 
de uma pessoa e depois mostrar na tela a classificação desta 
glicose de acordo com a tabela de referência ao lado.
Classificação  Glicose
Normal  Até 100 mg/dl
Elevado  Maior que 100 até 140 mg/dl
Diabetes  Maior de 140 mg/dl
Entrada
A entrada contém o valor de glicose com uma casa decimal.
Saída
A saída contém a classificação da glicose.
Exemplos:
Entrada  Saída
90.0  Normal
Entrada  Saída
140.0  Elevado
Entrada  Saída
143.2  Diabetes
     
     */

namespace Exemplo03
{
    class Program
    {
        static void Main(string[] args)
        {
            double glicose;
            glicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (glicose <= 100.0)
            {
                Console.WriteLine("Normal");
            }
            else if (glicose <= 140.0)
            {
                Console.WriteLine("Elevado");
            }
            else
            {
                Console.WriteLine("Diabetes");
            }
            Console.ReadLine();

        }
    }
}

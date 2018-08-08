using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 10) O curso de Computação Gráfica do IFTM é trimestral, sendo que as notas do ano são divididas em três partes: 30, 35 
e 35, totalizando 100 pontos no ano. O professor de programação está querendo automatizar o processo de fechamento de 
notas, fazendo um programa para somar as notas dos três trimestres de todos alunos da turma.
Entrada:
A entrada é composta por um número inteiro N representando a quantidade de alunos da turma, seguida pelas três notas 
de cada aluno da turma. As notas de um aluno são representadas por três números de ponto flutuante com duas casas 
decimais. 
Saída:
A saída mostra a nota final de cada aluno (duas casas decimais).
Exemplo:
Entrada  Saída
3
20.00 31.00 30.00
25.00 31.10 30.22
19.25 29.00 18.31
81.00
86.32
66.56
     */

namespace Exemplo09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double nota1, nota2, nota3, total;
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                total = nota1 + nota2 + nota3;
                Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}

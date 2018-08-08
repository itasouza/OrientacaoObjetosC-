using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 8) Leia três valores inteiros N, A e B. Em seguida, mostrar todos os múltiplos de N contidos no intervalo A e B (inclusive 
os próprios valores A e B).
Entrada:
A entrada é composta de três números inteiros N, A e B, respectivamente, sendo A < B (não precisa se preocupar em 
verificar se A é menor que B).
Saída:
A saída contém os múltiplos de N entre A e B, sendo um valor por linha. Se não houver nenhum, não se deve imprimir 
nada.
Exemplos:
Entrada  Saída
5
10
33
10
15
20
25
30
Entrada  Saída
8
2
7
     */

namespace Exemplo07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B;
            N = int.Parse(Console.ReadLine());
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                if (i % N == 0)
                { // testa se i é múltiplo de N
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}

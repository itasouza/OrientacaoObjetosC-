using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro
trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer
também se o aluno está aprovado ou não e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo
para ser aprovado (que é 60% da nota). Você deve criar uma classe Aluno para resolver este problema.
Exemplos:
Entrada: Saída:
João Pedro
27.00
31.00
32.00
NOTA FINAL = 90.00
APROVADO
Entrada: Saída:
João Pedro
17.00
20.00
15.00
NOTA FINAL = 52.00
REPROVADO
FALTARAM 8.00 PONTOS

 */

namespace Exemplo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();
            x.nome = Console.ReadLine();
            x.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + x.notaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (x.aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + x.quantoFaltaParaAprovacao().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

            Console.ReadLine();

        }
    }
}

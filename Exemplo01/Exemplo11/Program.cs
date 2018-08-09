using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:
• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
estoque)
• Realizar uma entrada no estoque e mostrar novamente os dados do produto
• Realizar uma saída no estoque e mostrar novamente os dados do produto
Para resolver este problema, você deve criar
uma CLASSE conforme projeto ao lado:

    Digite os dados do produto:
Nome: TV
Preço: 900.00
Quantidade em estoque: 10
Dados do produto: TV, R$ 900.00, 10 unidades, Total: R$ 9000.00
Digite a quantidade de produtos que entraram no estoque: 5
Dados atualizados: TV, R$ 900.00, 15 unidades, Total: R$ 13500.00
Digite a quantidade de produtos que saíram do estoque: 3
Dados atualizados: TV, R$ 900.00, 12 unidades, Total: R$ 10800.00

     */


namespace Exemplo11
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.Write("Qual o nome do produto:");

            p.nome = Console.ReadLine();

            Console.Write("Qual o preço do produto:");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Qual a quantidade de entrada no estoque :");
            p.realizarEntrada(int.Parse(Console.ReadLine()));


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos que entraram no estoque:");
            p.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos que sairam do estoque:");
            p.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.ReadLine();

        }
    }
}

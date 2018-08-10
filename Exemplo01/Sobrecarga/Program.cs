using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 E se eu quiser informar no construtor somente o nome e preço do produto, de
modo que a quantidade inicial de um produto seja 0 (zero) por padrão?

    SOBRECARGA: é o recurso que permite definir mais de uma versão da mesma
operação, diferenciando-as pela lista de parâmetros.

     */

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;

            Console.Write("Qual o nome do produto:");
            string nome = Console.ReadLine();

            Console.Write("Qual o preço do produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = new Produto(nome, preco);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque:");
            p.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que sairam do estoque:");
            p.realizarSaida(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.ReadLine();
        }
    }
}

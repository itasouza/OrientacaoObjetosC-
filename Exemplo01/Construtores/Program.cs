using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 * CONTRUTOR: é uma operação especial da classe, que executa no momento da
instanciação de um objeto.

    Palavra “this”:
É uma referência ao próprio objeto.
É como se o objeto falasse “eu mesmo”.

 */
namespace Construtores
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

            Console.Write("Qual a quantidade no estoque :");
            int quantidadde  = int.Parse(Console.ReadLine());

            p = new Produto(nome, preco, quantidadde);


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

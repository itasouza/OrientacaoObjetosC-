using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 O adequado é que toda lógica relacionada a produto esteja implementada na classe
Produto.
O programador que vai usar a classe Produto não precisa conhecer COMO essa
lógica foi implementada. Ele deve conhecer apenas O QUÊ a classe faz.
ENCAPSULAMENTO: consiste em esconder detalhes de implementação de uma
classe.
     
     */


/*
 Níveis de acesso em C# para atributos e
métodos:
public Sem restrição
private (padrão) Somente a própria classe pode acessar
protected Somente a própria classse e suas
subclasses podem acessar

internal Somente as classes do mesmo projeto
podem acessar

protected internal Somente as classes do mesmo projeto e
subclasses podem acessar
     
     */
namespace Encapsulamento
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

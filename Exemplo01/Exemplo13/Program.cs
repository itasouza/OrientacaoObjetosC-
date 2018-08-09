using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exemplo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome:");
            f.nome = Console.ReadLine();
            Console.Write("Salario bruto:");
            f.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto:");
            f.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do funcionário: " + f);

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            f.aumentarSalario( double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do funcionário: " + f);

            Console.ReadLine();

        }
    }
}

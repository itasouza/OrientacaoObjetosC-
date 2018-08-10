using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


/*
 * Exemplo usando construtores, encapsulamento e sobrecarga
 * 
 Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o
nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este
valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no
momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será,
naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.
Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de
casamento, por exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para
proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada
saque realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o
saldo não for suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação. 
 * 
 * 
 * Tipos referência = classe , aceita valor null, y = x , y passa a apontar para onde x aponta
 * tipos  valor = struct , não aceita valor null , y = x, y recebe uma cópia de x
 *      */

namespace ProjetoContrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;

            Console.Write("Digite o número da conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta:");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char ch = char.Parse(Console.ReadLine());

            if(ch == 's')
            {
                Console.Write("Digite o valor do depósito inicial : ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else{
                x = new Conta(numero, nome);
            }


            Console.WriteLine();
            Console.WriteLine("Conta Criada:");  
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito:");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);


            Console.WriteLine();
            Console.WriteLine("Conta Atualizada:");
            Console.WriteLine(x);


            Console.WriteLine();
            Console.Write("Digite um valor para saque:");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);

            Console.WriteLine();
            Console.WriteLine("Conta Atualizda:");
            Console.WriteLine(x);

            Console.ReadLine();

        }
    }
}

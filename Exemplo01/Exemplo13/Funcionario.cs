using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 Fazer um programa para ler os dados de um funcionário (nome, salário bruto e
desconto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em
seguida, aumentar o salário do funcionário com base em uma porcentagem dada e
mostrar novamente os dados do funcionário. Use a classe projetada abaixo.
     

    Nome: Joao Silva
Salario bruto: 6000.00
Desconto: 1000.00
Dados do funcionário: Joao Silva, R$ 5000.00
Deseja aumentar o salário em qual porcentagem? 10.0
Dados do funcionário: Joao Silva, R$ 5600.00

     */

namespace Exemplo13
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100);
        }

        public override string ToString()
        {
            return nome
                + ", R$ "
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}

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
     */

namespace Exemplo11
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;


        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }


        public override string ToString()
        {
            return nome
                + ", R$:  "
                + preco.ToString("F2", CultureInfo.InstalledUICulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades , Total R$: "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InstalledUICulture);
        }


    }
}

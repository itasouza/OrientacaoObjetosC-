﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;


        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }



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

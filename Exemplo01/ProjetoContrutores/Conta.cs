using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoContrutores
{
    class Conta
    {
        public int numero { get; private set; }
        public string titular { get; set; }
        public double saldo { get; private set; }


        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = 0.0;
        }

        public void depositar(double quantia)
        {
            saldo = saldo + quantia;
        }

        public void sacar(double quantia)
        {
            saldo = saldo - quantia - 5.0 ;
        }


        public override string ToString()
        {
            return "Conta"
                   + numero
                   + ", Titular: "
                   + titular
                   + ", Saldo: $"
                   + saldo.ToString("F2", CultureInfo.InvariantCulture);
                    
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo14
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;


        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool aprovado()
        {
            if (notaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double quantoFaltaParaAprovacao()
        {
            if (aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - notaFinal();
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
     1) Um agricultor precisa aplicar veneno em suas plantações. Para isso ele precisa escolher um frasco e uma bomba para 
aplicação. O frasco de veneno possui um volume de veneno líquido medido em ml (mililitro). Já a bomba de aplicação 
possui uma vazão* medida em ml/s (mililitro por segundo). O agricultor deseja saber: dado o volume inicial de um frasco 
de veneno (em ml), a vazão da bomba (em ml/s), e um tempo (em s), qual volume de veneno restará no frasco após o uso 
da bomba durante este tempo?
* Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo.
Entrada:
A entrada possui três números inteiros representando respectivamente: o volume inicial de um frasco de veneno (em ml), 
a vazão da bomba (em ml/s), e um tempo (em s).
Saída:
A saída contém um número inteiro representando o volume de veneno (em ml) restante no frasco depois o uso da bomba 
durante o tempo informado. Se o volume do frasco não for suficiente, mostre a mensagem "nao eh possivel".
Exemplos
   
    Entrada  Saída
400
2
30
340

Entrada  Saída
500
10
60
nao eh possivel
  
    */


namespace Exemplo01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int volumeInicial, vazao, tempo, volumeFinal;
            volumeInicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());
            if (vazao * tempo > volumeInicial)
            {
                Console.WriteLine("nao eh possivel");
            }
            else
            {
                volumeFinal = volumeInicial - (vazao * tempo);
                Console.WriteLine(volumeFinal);
            }
            Console.ReadLine();
        }
    }
}

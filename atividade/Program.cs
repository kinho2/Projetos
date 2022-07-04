using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {

            int cod1 = 1, cod2 = 2, quantidade1 = 1, quantidade2 = 2;
            float preco1 = 5.30f;
            float preco2 = 5.10f;
            float total = quantidade1 * preco1 + quantidade2 * preco2;

            Console.Write("CODIGO  "); 
            Console.WriteLine(cod1);
            Console.Write("CODIGO  "); 
            Console.WriteLine(cod2);
            Console.Write("QUANTIDADE CODIGO1 =  ");
            Console.WriteLine(quantidade1);
            Console.Write("QUANTIDADE CODIGO2 =  ");
            Console.WriteLine(quantidade2);
            Console.Write("PREÇO CODIGO 1 = ");
            Console.WriteLine(preco1);
            Console.Write("PREÇO CODIGO 2 = ");
            Console.WriteLine(preco2);
            Console.Write("TOTAL");
            Console.WriteLine(total);


        }
    }
}

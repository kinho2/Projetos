using System;
using System.Globalization;

namespace correcao {
    class program {
        static void Main(string[] args) {
            Console.WriteLine("Escolha o codigo do pedido: ");
            Console.WriteLine("cod 1 - Cachorro quente - R$4.00");
            Console.WriteLine("cod 2 - X-salada - R$4.50");
            Console.WriteLine("cod 3 - X-bacon - R$5.00");
            Console.WriteLine("cod 4 - Torradas simples - R$2.00");
            Console.WriteLine("cod 5 - refrigerante - R$1.50");

            Console.WriteLine("Digite o codigo do produto e quantidade: ");

            string[] codvalor = Console.ReadLine().Split(' ');
            int codigo = int.Parse(codvalor[0]);
            int quantidade = int.Parse(codvalor[1]);

            double total;
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else if (codigo == 5) {
                total = quantidade * 1.5;
            }
            else {
                Console.WriteLine("Digite um codigo correto");
            return;
            }
            Console.WriteLine("total R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
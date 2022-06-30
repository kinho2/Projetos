using System;
using System.Globalization;

namespace atiestruturaCondicional {
    class program {
        private static object cultureinfo;

        static void Main(string[] args) {

            Console.WriteLine("Entre com o numero:");
            int x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("NEGATIVO");
            }

            else {
                Console.WriteLine("positivo");
            }

            Console.WriteLine("---------------");

            Console.WriteLine("Entre com o numero:");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) {
                Console.WriteLine("PAR");
            }

            else {
                Console.WriteLine("IMPAR");
            }

            Console.WriteLine("---------------");

            Console.WriteLine("escreva os numeros");

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.WriteLine("Informa o horario de começo do jogo");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Informa o horario de fim do jogo");
            int horaf = int.Parse(Console.ReadLine());
            int duração;
            if (hora < horaf) {
                duração = horaf - hora;
                Console.WriteLine($"Horas de jogo: {duração}");
            }
            else {
                duração = 24 - hora + horaf;
                Console.WriteLine($"Horas de jogo: {duração}");

            }
            //string[] valoresh = (Console.ReadLine().Split());
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);
            //int duracao;
            //if (horaInicial < horaFinal) {
            //   duracao = horaFinal - horaInicial;
            //}
            //else {
            //    duracao = 24 - horaInicial + horaFinal;
            //}
            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine();


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
//(codigo == 5) //
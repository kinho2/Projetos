using System;

namespace senha {

    class program {
        static void Main(string[] args) {

            Console.WriteLine("Digite sua senha de acesso:");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2002) {
                Console.WriteLine("Senha invalida, tentativas restantes(2)");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha invalida, tentativas restantes(1)");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine("Senha invalida, app encerrado");
                senha = int.Parse(Console.ReadLine());
                return;
            }
            Console.WriteLine("Acesso permitido");

            Console.WriteLine("--------------------");
            Console.WriteLine("Digite sua primeira coordenada cordenadas");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse((string)valores[0]);
            int y = int.Parse((string)valores[1]);


            if (x >= 0 && y >= 0) {
                Console.WriteLine("PRIMEIRO");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("SEGUNDO");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("TERCEIRO");
            }
            else {
                Console.WriteLine("QUARTO");
            }

            Console.WriteLine("Digite a sua seguda coordernada cordenadas");
            valores = Console.ReadLine().Split(' ');
            x = int.Parse((string)valores[0]);
            y = int.Parse((string)valores[1]);

            if (x >= 0 && y >= 0) {
                Console.WriteLine("PRIMEIRO");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("SEGUNDO");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("TERCEIRO");
            }
            else {
                Console.WriteLine("QUARTO");
            }

            // 1.Álcool 2.Gasolina 3.Diesel 4.Fim.//

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim");

            int tipo = int.Parse(Console.ReadLine());
            while (tipo != 4) {
                Console.WriteLine("OBRIGADO");

                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }
                else if (tipo >= 5) {
                    Console.WriteLine("Digite numero valido");
                    return;
                }
                tipo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Alcool = {alcool}");
                Console.WriteLine($"gasolina = {gasolina}");
                Console.WriteLine($"Diesel = {diesel}");
            }
        }
    }
}

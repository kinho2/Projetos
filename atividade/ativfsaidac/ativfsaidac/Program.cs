using System;
using System.Globalization;

namespace Ativfsaidac {

    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;


            Console.WriteLine($"{produto1}, cujo preço é {preco1:F1}");
            Console.WriteLine($"{produto2}, cujo o preço é {preco2:F2}");
            Console.WriteLine("                                    ");
            Console.WriteLine("                                    ");

            Console.WriteLine ($"Registro: {idade} anos de idade, codigo: {codigo} e gênero: {genero}");
            Console.WriteLine("                                    ");
            Console.WriteLine("                                    ");
            Console.WriteLine ($"Media com 8 casas dacimais {media:F8}");
            Console.WriteLine($"Arredondo (três casas dacimais) {media:F3}");
            Console.WriteLine($"Separador de decimal usando o invariante culture: {media.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
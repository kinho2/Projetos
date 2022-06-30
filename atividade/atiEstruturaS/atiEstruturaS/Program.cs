using System.Globalization;

namespace atiEstruturaS {
    class program {
        static void Main(string[] args) {
            //CALCULO PRADRÃO
            Console.WriteLine("Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos");
            Console.WriteLine("atividade de somar:");
            Console.WriteLine("");

            int a, b, soma1;

            Console.WriteLine("Valor de A = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B = ");
            b = int.Parse(Console.ReadLine());
            soma1 = a + b;
            Console.WriteLine(soma1);
            Console.WriteLine("");


            //NUMERO PI
            Console.WriteLine("");
            Console.WriteLine("Valor do raio a ser calculado:");

            double R, A1, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A1 = pi * R * R;

            Console.WriteLine("A =" + A1.ToString("F4", CultureInfo.InvariantCulture));

            //DIFERENCA = (A * B - C * D).
            Console.WriteLine("DIFERENÇA ATRAVEZ DO CAL (A * B - C * D):");
            Console.WriteLine("");
            int A, B, C, D, DIFERENCA;
            Console.WriteLine("Valor de A = ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B = ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C = ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de D = ");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = A * B - C * D;
            Console.WriteLine($"A DIFERENCIA É DE: {DIFERENCA}");

            /// SALARIO 
            Console.WriteLine("Calcule o seu salario:");
            Console.WriteLine("");

            int codigo, numhora;
            decimal salario, SOMAS;

            Console.WriteLine("Digite o seu codigo:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Numeros de horas trabalhadas:");
            numhora = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do salario por horas trabalhadas:");
            salario = decimal.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            SOMAS = salario * numhora;

            Console.WriteLine($"NUMBER: {codigo}");

            Console.WriteLine($"SALARY U$: {SOMAS.ToString(CultureInfo.InvariantCulture)}");


            //nota fiscal

            Console.WriteLine("Nota fiscal de 2 produtos:");

            double soma3, preco1, preco2; 
            int quantidade1, quantidade2;

            Console.WriteLine("Digite o nome do produto:");
            string produto = Console.ReadLine();
            Console.WriteLine("Quantidade do produto:");
            quantidade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("valor por unidade:");
            preco1 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.WriteLine("Digite o nome do produto:");
            Console.ReadLine();
            Console.WriteLine("Quantidade do produto:");
            quantidade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por unidade:");
            preco2 = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Console.WriteLine("");

            soma3 = (preco2 * quantidade2) + (preco1 * quantidade1);

            Console.WriteLine(produto);
            Console.WriteLine($"A quantidade de produtos é: {quantidade1 + quantidade2}");
            Console.WriteLine($"Soma total dos produtos é = {soma3.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
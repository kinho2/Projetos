using System;
using System.Globalization;

namespace projetosdeclass {
    class Program {
        static void Main(string[] args) {

            /*Retengulo r = new Retengulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A area do retangulo é igual a: " + r);

            Console.WriteLine("-------------------------------------------");

            Funcionario f = new Funcionario();

            Console.WriteLine("Infome dados do funcionario");
            Console.Write("Nome do funcionario: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salrio bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("imposto");
            f.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Dados do funcionario: " + f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);
            Console.WriteLine(" Dados do funcionario: " + f);*/

            Console.WriteLine("-------------------------------------------");
            Aluno n = new Aluno();

            

            Console.WriteLine("Nome do aluno:");
            Console.WriteLine("Digite as Treês notas do aluno:");
            n.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n);


            if (n.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Pontos faltando = {n.Notarest()} pontos ");
            }


        }
    }
}

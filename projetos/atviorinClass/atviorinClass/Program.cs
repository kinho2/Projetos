using atviorinClass;
using System;
using System.Globalization;

namespace ativorinClass {
    class program {
        static void Main(string[] args) {


            Pessoas nome, idade;
            Pessoas n1 = new Pessoas();
            Pessoas n2 = new Pessoas();

            Console.WriteLine("Digite o nome da pessoa: ");
            n1.nome = Console.ReadLine();
            Console.WriteLine("Idade da pessao: ");
            n1.idade =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da pessoa: ");
            n2.nome = Console.ReadLine();
            Console.WriteLine("Idade da pessao: ");
            n2.idade = int.Parse(Console.ReadLine());

            if (n1.idade > n2.idade) {
                Console.WriteLine("A mais velha é: " + n1.nome + " com: "+n1.idade);
            }
            else {
                Console.WriteLine("A mais velha é" + n2.nome + " com: " + n2.idade);
            }

            Funcionario nomef, salario;
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
           



            Console.WriteLine("--------------------");
            Console.WriteLine("Nome do funcionario");
            f1.nomef = Console.ReadLine();
            Console.WriteLine("Salarido do funcionario");
            f1.salario = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: "+ f1.nomef + "com salario de " + f1.salario.ToString("F2",CultureInfo.InvariantCulture));


            Console.WriteLine("--------------------");
            Console.WriteLine("Nome do funcionario");
            f2.nomef = Console.ReadLine();
            Console.WriteLine("Salarido do funcionario");
            f2.salario = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + f2.nomef + "com salario de " + f2.salario.ToString("F2", CultureInfo.InvariantCulture));
            double media = (f1.salario + f2.salario)/2;

            Console.WriteLine("A media salarial é: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;
namespace imposto {
    class program {
        static void Main(string[] args) {
            double imposto;


            Console.WriteLine("Digite sua renda mensal: ");
            double renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if (renda <= 2000.0) {
                Console.WriteLine("isento");
                return;
            }
            else if (renda > 2000.01 && renda < 3000.00) {
                imposto = (renda - 2000.0) * 0.08;
                Console.WriteLine("8% = " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda > 3000.01 && renda < 4500.00) {
                imposto = (renda - 3000.0) * 0.18 + 1000 * 0.08;
                Console.WriteLine("18% = " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (renda > 4500.00){
                imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                //imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine("18% = " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }

}


using System;
namespace for1;
class program {
    static void Main(string[] args) {
        Console.Write("Quantos numero você vai digitar: ");
        int N = int.Parse(Console.ReadLine());
        
        int soma = 0;
        for (int i = 1; i <= N; i++) {
            Console.Write("valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma = soma + valor;
        }
        Console.WriteLine($"soma = {soma}");
    }
}

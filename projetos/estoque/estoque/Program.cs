using System;
using System.Globalization;

namespace estoque {
    class Program {
        static void Main(string[] args) {
            Produto p = new Produto();



            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produtos: " + p);
            
            
            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser adicionada: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos a ser removidos: ");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

using System;
using System.Globalization;

namespace atividadeProjeto {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("FICHA CADASTRAL");
            Console.Write("Digite o nome da sua pousada: ");
            string nomecompleto = Console.ReadLine();
            Console.Write("quantos quartos tem em sua em sua pousada? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço dos quartos (a media): ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Ficha do proprietário");
            Console.WriteLine("Digite os seguintes dados na ordem e mesma linha: ");
            Console.Write("Nome - Idade - CPF - Numero de Tel: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            decimal CPF = decimal.Parse(vet[2]);
            decimal numerotel = decimal.Parse(vet[3]);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Nome da pousada:  ");
            Console.WriteLine(nomecompleto);
            Console.WriteLine();
            Console.Write("Quantidade de quartos na pousada:  ");
            Console.WriteLine(quartos);
            Console.WriteLine();
            Console.Write("Preço do produto(quartos): ");
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();


            Console.WriteLine($"Seu nome é {nome} sua idade é {idade}, seu CPF é {CPF} e seu numero de telefone é {numerotel}.  ");
            Console.WriteLine("");
            Console.WriteLine("tudo certo com o seu cadrasto, aguarde o retorno do site para mais detanhes!!!");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Empresa {
    class Program {

        static void Main(string[] args) {
            Console.Write("Quantos funcionario deseja cadrastar: ");
            List<Funcionario> list1 = new List<Funcionario>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Funcionario #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");                
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                list1.Add(new Funcionario (id, nome, salario));
            }

            Console.Write("Entre com o Id do Fucionario que deseja acrescentar salario: ");
            int pesquisaid = int.Parse(Console.ReadLine());
            Funcionario func = list1.Find(x => x.Id == pesquisaid);
            if (func != null) {
                Console.Write("Entre com o valor em porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());
                func.IncrementarSalario(porcentagem);
            }
            else {
                Console.WriteLine("Digite o id da maneira correta");
            }
               
            foreach(Funcionario obj in list1) {
                Console.WriteLine("Dados atualizados:");
                Console.WriteLine(obj);
                Console.WriteLine(func);
                Console.ReadKey();
            }

            Console.ReadKey();

            
        }

    }
}

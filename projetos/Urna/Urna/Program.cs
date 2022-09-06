using System;
using System.IO;
using System.Collections.Generic;
namespace Urna
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                Console.Write("Indique quantas urnas a ser contabilizadas: ");
                int n = int.Parse(Console.ReadLine());


                for (int i = 0; i < n; i++)
                {
                  int urna =  i + 1;
                    Console.Write("Indique numero de candidatos da urna " + "[" + urna + "]: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite candidato e voto usando a caracteristica ',' para separar: ");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("Candidato e quantidade de voto: ");
                        string[] votosRegistros = Console.ReadLine().Split(',');
                        string candidatos = votosRegistros[0];
                        int votos = int.Parse(votosRegistros[1]);

                        if (dictionary.ContainsKey(candidatos))
                        {
                            dictionary[candidatos] += votos;
                        }
                        else
                        {
                            dictionary[candidatos] = votos;
                        }
                        
                    }
                    Console.WriteLine();
                }
                foreach (var item in dictionary)
                {
                    Console.WriteLine("Total de votos apurados foi " + item.Key + ": " + item.Value);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }

    }
}


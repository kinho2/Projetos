using System;
using System.Collections.Generic;
namespace PortCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int>couserA = new HashSet<int>();
            HashSet<int>couserB = new HashSet<int>();
            HashSet<int>couserC = new HashSet<int>();
            

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                couserA.Add(cod);
            }

            Console.Write("How many students for course B? ");
             n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                couserB.Add(cod);
            }

            Console.Write("How many students for course C? ");
             n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                couserC.Add(cod);
            }
            HashSet<int> allCode = new HashSet<int>(couserA);
            allCode.UnionWith(couserB);
            allCode.UnionWith(couserC);
            Console.WriteLine("Total de alunos " + allCode.Count);
            
        
        }
    }
}

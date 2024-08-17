using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            int num = 0, q1 = 0, q2 = 0, q3 = 0, q4 = 0;

            while (num >= 0)
            {
                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());

                if(num >= 0 && num <= 25)
                {
                    q1 += 1;
                }else if(num>=26 && num <= 50)
                {
                    q2 += 1;
                }else if(num >= 51 && num <= 75)
                {
                    q3 += 1;
                }else if(num>=76 && num <= 100)
                {
                    q4 += 1;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.WriteLine("A quantidade de números no intervalo entre");
            Console.WriteLine($"0 - 25: {q1}");
            Console.WriteLine($"26 - 50: {q2}");
            Console.WriteLine($"51 - 75: {q3}");
            Console.WriteLine($"76 - 100: {q4}");
            Console.WriteLine("=====================================================");
            Console.ReadKey();

        }
    }
}

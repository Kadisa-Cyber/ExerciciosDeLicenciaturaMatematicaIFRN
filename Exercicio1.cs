using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            int num = 500, somaT = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    if (i % 3 == 0)
                    {
                        somaT += i;
                    }
                }
            }

            Console.WriteLine($"A soma dos números impares e multiplos de três entre 1 e 500 é {somaT}");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Os números impares entre 100 e 200 são:");

            for(int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        } 
    }
}

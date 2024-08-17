using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio7
    {
        static void Main(string[] args)
        {
            int N=0;

            while(N<1 || N > 10)
            {
                Console.WriteLine("Digite um número de 1 a 10");
                N = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{N} X {i} = {N*i}");
            }
            Console.ReadKey();
        }
    }
}

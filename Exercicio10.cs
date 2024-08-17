using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            int num, fat = 1;

            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            Console.Write($"{num}! = ");

            for (int i = num; i >= 1; i--)
            {
                fat *= i;

                Console.Write(i);

                if (i != 1)
                {
                    Console.Write("X");
                }

            }

            Console.Write($" = {fat} ");
            Console.ReadKey();


        }
    }
}

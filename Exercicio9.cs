using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio9
    {
        static void Main(string[] args)
        {
            int razao, num;

            Console.WriteLine("Digite um número");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a razão da PG");
            razao = int.Parse(Console.ReadLine());


            Console.WriteLine($"A progressão geométrica com número inicial {num} e razão {razao} é:");
            Console.WriteLine(num);
            for (int i = 1; i <= 9; i++)
            {
                num *= razao;
                Console.WriteLine(num);
            }

            Console.ReadKey();

        }
    }
}

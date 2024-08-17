using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
            int menorP = 0, maiorP = 0, i = 1, peso;

            while (i <= 15)
            {
                peso = -1;
                while (peso <= 0)
                {
                    Console.WriteLine("Digite seu peso");
                    peso = int.Parse(Console.ReadLine());

                    if (peso < 0)
                    {
                        Console.WriteLine("Impossivel algo ter o peso negativo, digite um número válido!");
                    }
                }


                if (menorP == 0)
                {
                    menorP = peso;
                }

                if (maiorP == 0)
                {
                    maiorP = peso;
                }

                if (peso < menorP)
                {
                    menorP = peso;
                }

                if (peso > maiorP)
                {
                    maiorP = peso;
                }

                i++;
            }

            Console.WriteLine($"O menor peso é: {menorP}");
            Console.WriteLine($"O maior peso é: {maiorP}");
            Console.ReadKey();
        }
    }
}

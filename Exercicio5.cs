using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio5
    {
        static void Main(string[] args)
        {
            int qntP = 0, qntI = 0, num=1;
            double mediaP, somaP=0, mediaG, somaG=0, totalP=0, totalG=0;

            while(num != 0)
            {

                num = -1;

                while (num < 0)
                {
                    Console.WriteLine("Digite um número");
                    num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine("Digite um número válido, acima de zero!");
                        Console.WriteLine("=======================================");
                    }
                }
                

                if (num % 2 == 0  && num != 0)
                {
                    qntP += 1;
                    somaP += num;
                    totalP += 1;
                }
                else
                {
                    if (num != 0)
                    {
                        qntI += 1;
                    }
                }

                if (num != 0)
                {
                    somaG += num;
                    totalG += 1;
                }
            }

            mediaP = somaP / totalP;
            mediaG = somaG / totalG;

            Console.WriteLine($"Números pares: {qntP}");
            Console.WriteLine($"Números ímpares: {qntI}");
            Console.WriteLine($"A média dos valores pares foi: {Math.Round(mediaP, 2)}");
            Console.WriteLine($"A média dos valores em geral foi: {Math.Round(mediaG, 2)}");
            Console.ReadKey();
        }
    }
}

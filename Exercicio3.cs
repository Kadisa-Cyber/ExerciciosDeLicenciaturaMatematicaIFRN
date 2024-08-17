
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade
{
    internal class Exercicio3
    {
        static void Main(string[] args)
        {
            bool sair = false;
            double num, media, somaT=0, qntP = 0, qntNg = 0, total = 0, qntNe = 0, percNe, percNg, percP;
            string opc;


            while (sair == false)
            {
                Console.WriteLine("Digite um número");
                num = double.Parse(Console.ReadLine());

                total += 1;

                somaT += num;

                if (num == 0)
                {
                    qntNe += 1;
                }
                else if (num > 0)
                {
                    qntP += 1;
                }
                else
                {
                    qntNg += 1;
                }

                opc = "C";

                while (opc != "S" && opc != "N")
                {
                    Console.WriteLine("Deseja digitar mais um número?");
                    Console.WriteLine("Digite S para continuar");
                    Console.WriteLine("Digite N para encerrar");
                    opc = Console.ReadLine();

                    if (opc != "S" && opc != "N")
                    {
                        Console.WriteLine("Escolha uma opção válida!");
                    }
                }

                if (opc == "N")
                {
                    break;
                }

            }


            media = somaT / total;

            percP = (qntP / total) * 100;
            percNg = (qntNg / total) * 100;
            percNe = (qntNe / total) * 100;

            Console.WriteLine("");
            Console.WriteLine("==================================================================");
            Console.WriteLine($"A média aritmética dos números lidos foi: {Math.Round(media, 2)}");
            Console.WriteLine("==================================================================");
            Console.WriteLine($"A quantidade de números positivos foi {qntP}");
            Console.WriteLine($"A quantidade de números negativos foi {qntNg}");
            Console.WriteLine($"A quantidade de números neutros foi {qntNe}");
            Console.WriteLine("==================================================================");
            Console.WriteLine($"O percertual de números positivos foi {Math.Round(percP,2)}%");
            Console.WriteLine($"O percertual de números negativos foi {Math.Round(percNg,2)}%");
            Console.WriteLine($"O percertual de números neutros foi {Math.Round(percNe,2)}%");
            Console.WriteLine("==================================================================");
            Console.ReadKey();


        }
    }
}

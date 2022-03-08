using System;

namespace Distancia_entre_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano1, ano2, max, min;

            Console.WriteLine("Digite o Primeiro ano");
            ano1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo ano");
            ano2 = Convert.ToInt32(Console.ReadLine());

            if (ano1 > ano2)
            {
                max = ano1;
                min = ano2;
            }
            else
            {
                max = ano2;
                min = ano1;
            }

            int cont = 0;
            for (int i = min; i < max; i++)
            {
                if (i % 4 == 0 && i % 100 == 0 && i % 400 == 0)
                {
                    cont++;
                    Console.WriteLine($"{i}  foi ano bissexto");
                }
                else if (i % 4 == 0 && i % 100 != 0)
                {
                    cont++;
                    Console.WriteLine($"{i}  foi ano bissexto");
                }

            }

            int totaldias = ((max - min) * 365) + cont;

            Console.WriteLine($"entre {max} e {min} tem {totaldias} dias");

        }
    }
}

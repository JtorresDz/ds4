using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Escribe el número para la dimension dinamica n: ");
        string dn = Console.ReadLine();
        Random r = new Random();

        if (int.TryParse(dn, out int n) && n > 0 && n % 2 == 0)
        {
            int[,] matriz = new int[n, n];
            long M = 0;
            long A = 0;

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f % 2 != 0)
                    {
                        matriz[f, c] = r.Next(101, 200);
                        A = matriz[f, c];
                        M = M * A;
                    }
                    else
                    {
                        matriz[f, c] = 0;
                    }
                }
            }

            Console.WriteLine($"\nMatriz de {n}x{n}:");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{matriz[f, c],4} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nEl resultado de la multipliacion de todos los numeros aleatorios es: {0}",M);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debes escribir un número entero positivo y par.");
        }
    }
}
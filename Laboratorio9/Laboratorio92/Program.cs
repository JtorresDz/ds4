using Laboratorio92;
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[100];
        int j;

        for (j = 0; j < 100; j++)
        {
            numeros[j] = j + 1;
        }

        Divisibles nd = new Divisibles();
        Divisibles.MostrarDivisibles(numeros);

        Pares np = new Pares();
        Pares.MostrarPares(numeros);
        Console.WriteLine("\n\n");    
    }
        
}

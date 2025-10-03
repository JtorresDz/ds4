using System;

namespace Laboratorio92
{
    class Pares
    {
        public static void MostrarPares(int[] numeros)
        {
            Console.Write("\n\nNúmeros pares:");
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Console.Write(numero+", ");
                }
            }
        }
    }
}

using System;

namespace Laboratorio92
{
    class Divisibles
    {
        public static void MostrarDivisibles(int[] numeros)
        {
            Console.Write("Números divisibles entre 3: ");
            foreach (int numero in numeros)
            {
                if (numero % 3 == 0)
                {
                    Console.Write(numero + ", ");
                }
            }
        }
    }
}

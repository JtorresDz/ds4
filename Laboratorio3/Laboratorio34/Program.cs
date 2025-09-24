using System;

namespace Laboratorio34
{
    class Program
    {
        public class CalculosMatematicos
        {
            public static int Calcular(int a, int b)
            {
                int resultado = (a + b) * (a - b);
                return resultado;
            }

            public static double calculoArea(int a)
            {
                double pi = 3.14;
                double resultado = pi * (a ^ 2);
                return resultado;
            }

        }

        public static void Main(string[] args)
        {
            int na, nb;

            Console.WriteLine("Introduce el primer numero: ");
            na = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            nb = Convert.ToInt32(Console.ReadLine());

            int res = CalculosMatematicos.Calcular(na, nb);

            Console.WriteLine("El resultado de la operacion ({0}+{1}) * ({0}-{1}) es: {2}", na, nb, res);

        }
    }
}
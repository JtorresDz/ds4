using System;

namespace Laboratorio33
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
            int cr;

            Console.WriteLine("Introduce el radio del circulo: ");
            cr = Convert.ToInt32(Console.ReadLine());

            double res = CalculosMatematicos.calculoArea(cr);

            Console.WriteLine("El resultado del area del circulo es: {0}", res);

        }
    }
}